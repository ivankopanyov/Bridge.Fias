using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System;
using Microsoft.Extensions.Hosting;
using Bridge.Fias.FiasInterface;
using Bridge.Fias.Entities;
using System.Linq;

namespace Bridge.Fias.SocketClient
{
    internal class FiasSocketClient : BackgroundService
    {
        private const char HEAD = FiasEnviroments.HEAD;

        private const char TAIL = FiasEnviroments.TAIL;

        private readonly string _separator = $"{TAIL}{HEAD}";

        private readonly IFiasService _fiasService;

        private Socket _socket;

        private string _lastError;

        public FiasSocketClient(IFiasService fiasService)
        {
            _fiasService = fiasService;
            _fiasService.FiasSendMessageEvent += SendAsync;
        }

        protected sealed override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (true)
                await Task.Run(ConnectAsync);
        }

        private async Task ConnectAsync()
        {
            if (_fiasService.CancellationToken.IsCancellationRequested)
            {
                _fiasService.RefreshCancellationToken();
                await Task.Delay(6000);
            }

            if (!_fiasService.IsRunning)
                return;

            if (_fiasService.CancellationToken.IsCancellationRequested)
                return;

            using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
            {
                if (!ConnectToFias(socket))
                    return;

                if (_fiasService.CancellationToken.IsCancellationRequested)
                    return;

                _fiasService.ChangeConnectionStateEventInvoke(true, _fiasService.Hostname, _fiasService.Port);

                StringBuilder stringBuilder = new StringBuilder();

                try
                {
                    _socket = socket;
                    while (true)
                    {
                        if (!socket.Connected)
                        {
                            _socket = null;
                            _fiasService.ChangeConnectionStateEventInvoke(false, _fiasService.Hostname, _fiasService.Port);
                            break;
                        }

                        await Task.Run(async () => await ReadAsync(socket, stringBuilder));

                        if (_fiasService.CancellationToken.IsCancellationRequested)
                            break;
                    }
                }
                catch (Exception ex)
                {
                    _socket = null;
                    _fiasService.ErrorEventInvoke(ex.Message, ex);
                    _fiasService.ChangeConnectionStateEventInvoke(false, _fiasService.Hostname, _fiasService.Port);
                }
            }
        }

        private async Task ReadAsync(Socket socket, StringBuilder stringBuilder)
        {
            ArraySegment<byte> buffer = new ArraySegment<byte>(new byte[8192]);
            try
            {
                var size = await socket.ReceiveAsync(buffer, SocketFlags.None);

                if (size > 0)
                {
                    var array = buffer.ToArray();
                    if (size < array.Length)
                        Array.Resize(ref array, size);

                    var temp = Encoding.Default.GetString(array, 0, size);
                    var messages = temp.Split(new string[] { _separator }, StringSplitOptions.None);

                    if (messages.Length == 1 && messages[0].Length > 0)
                    {
                        if (messages[0][messages[0].Length - 1] != TAIL)
                        {
                            if (messages[0][0] != HEAD)
                                stringBuilder.Append(messages[0]);
                            else
                                stringBuilder.Clear().Append(messages[0].Substring(1));
                        }
                        else
                        {
                            var message = FixHead(messages[0], stringBuilder);
                            MessageHandle(message);
                            stringBuilder.Clear();
                        }
                    }
                    else if (messages.Length > 1)
                    {
                        var message = messages[0].Length != 0 ? FixHead(messages[0], stringBuilder) : stringBuilder.ToString();
                        MessageHandle(message);
                        stringBuilder.Clear();

                        for (int i = 1; i < messages.Length - 1; i++)
                            MessageHandle(messages[i]);

                        message = messages[messages.Length - 1];

                        if (message.Length != 0)
                        {
                            if (message[message.Length - 1] != TAIL)
                                stringBuilder.Append(message);
                            else
                                MessageHandle(message.Substring(1, message.Length - 1));
                        }
                    }
                }
            }
            catch (OperationCanceledException)
            {
                _socket = null;
                _fiasService.ChangeConnectionStateEventInvoke(false, _fiasService.Hostname, _fiasService.Port);
            }
        }

        private void MessageHandle(string message)
        {
            var commonMessage = FiasCommonMessage.FromString(message);

            if (commonMessage.ToFiasMessageFromPmsObject() is object fiasMessage)
                _fiasService.MessageEventInvoke(fiasMessage);
            else
                _fiasService.UnknownTypeMessageEventInvoke(commonMessage);
        }

        private Task SendAsync(string message)
        {
            if (message is null)
                throw new ArgumentException("The message was not sent because it is null.");

            if (_socket is null)
                throw new InvalidOperationException("The message was not sent because the connection to FIAS was not established.");

            try
            {
                var buffer = Encoding.Default.GetBytes(message);
                _socket.SendAsync(new ArraySegment<byte>(buffer), SocketFlags.None);
                return Task.CompletedTask;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(ex.Message, ex);
            }
        }

        private bool ConnectToFias(Socket socket)
        {
            if (_fiasService.CancellationToken.IsCancellationRequested)
                return false;

            if (string.IsNullOrWhiteSpace(_fiasService.Hostname))
            {
                TrySendError("Hostname is null or whitespace");
                return false;
            }

            if (_fiasService.CancellationToken.IsCancellationRequested)
                return false;

            if (_fiasService.Port < IPEndPoint.MinPort || _fiasService.Port > IPEndPoint.MaxPort)
            {
                TrySendError($"Port {_fiasService.Port} out of range [{IPEndPoint.MinPort}..{IPEndPoint.MaxPort}]");
                return false;
            }

            if (_fiasService.CancellationToken.IsCancellationRequested)
                return false;

            try
            {
                if (!socket.ConnectAsync(_fiasService.Hostname, _fiasService.Port).Wait(1000, _fiasService.CancellationToken))
                {
                    TrySendError($"The remote host {_fiasService.Hostname}:{_fiasService.Port} was not found.");
                    return false;
                }

                _lastError = null;
                return true;
            }
            catch (OperationCanceledException)
            {
                return false;
            }
            catch (AggregateException)
            {
                TrySendError($"Failed to connect to remote host {_fiasService.Hostname}:{_fiasService.Port}");
                return false;
            }
            catch (Exception ex)
            {
                TrySendError(ex.Message, ex);
                return false;
            }
        }

        private void TrySendError(string message, Exception ex = null)
        {
            if (_lastError == null || _lastError != message)
            {
                _lastError = message;
                _fiasService.ErrorEventInvoke(message, ex);
            }
        }

        public static IPEndPoint GetIPEndPointFromHostName(string hostName, int port)
        {
            var addresses = Dns.GetHostAddresses(hostName);
            if (addresses.Length == 0)
                throw new ArgumentException("Unable to retrieve address from specified host name.", nameof(hostName));

            return new IPEndPoint(addresses[0], port);
        }

        private static string FixHead(string message, StringBuilder stringBuilder)
            => message[0] != HEAD ? stringBuilder.Append(message.Substring(0, message.Length - 1)).ToString() : message.Substring(1, message.Length - 2);
    }
}
