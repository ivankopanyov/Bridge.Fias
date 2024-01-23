using System.Threading;
using System;
using Bridge.Fias.Entities;
using Microsoft.Extensions.Options;

namespace Bridge.Fias.FiasInterface
{
    internal class FiasService : IFiasService
    {
        #region Events

        public event FiasMessageHandle<FiasLinkStart> FiasLinkStartEvent;
        public event FiasMessageHandle<FiasLinkAlive> FiasLinkAliveEvent;
        public event FiasMessageHandle<FiasLinkEnd> FiasLinkEndEvent;
        public event FiasMessageHandle<FiasMessageDelete> FiasMessageDeleteEvent;
        public event FiasMessageHandle<FiasWakeupClear> FiasWakeupClearEvent;
        public event FiasMessageHandle<FiasWakeupRequest> FiasWakeupRequestEvent;
        public event FiasMessageHandle<FiasDatabaseResyncEnd> FiasDatabaseResyncEndEvent;
        public event FiasMessageHandle<FiasDatabaseResyncStart> FiasDatabaseResyncStartEvent;
        public event FiasMessageHandle<FiasGuestBillBalance> FiasGuestBillBalanceEvent;
        public event FiasMessageHandle<FiasGuestBillItem> FiasGuestBillItemEvent;
        public event FiasMessageHandle<FiasGuestChange> FiasGuestChangeEvent;
        public event FiasMessageHandle<FiasGuestCheckIn> FiasGuestCheckInEvent;
        public event FiasMessageHandle<FiasGuestCheckOut> FiasGuestCheckOutEvent;
        public event FiasMessageHandle<FiasKeyDataChange> FiasKeyDataChangeEvent;
        public event FiasMessageHandle<FiasKeyDelete> FiasKeyDeleteEvent;
        public event FiasMessageHandle<FiasKeyReadResponse> FiasKeyReadResponseEvent;
        public event FiasMessageHandle<FiasKeyRequest> FiasKeyRequestEvent;
        public event FiasMessageHandle<FiasLinkConfiguration> FiasLinkConfigurationEvent;
        public event FiasMessageHandle<FiasLocatorRetrieveResponse> FiasLocatorRetrieveResponseEvent;
        public event FiasMessageHandle<FiasMessageText> FiasMessageTextEvent;
        public event FiasMessageHandle<FiasMessageTextOnlineResponse> FiasMessageTextOnlineResponseEvent;
        public event FiasMessageHandle<FiasNightAuditEnd> FiasNightAuditEndEvent;
        public event FiasMessageHandle<FiasNightAuditStart> FiasNightAuditStartEvent;
        public event FiasMessageHandle<FiasPostingAnswer> FiasPostingAnswerEvent;
        public event FiasMessageHandle<FiasPostingList> FiasPostingListEvent;
        public event FiasMessageHandle<FiasRemoteCheckOutResponse> FiasRemoteCheckOutResponseEvent;
        public event FiasMessageHandle<FiasRoomEquipmentStatusResponse> FiasRoomEquipmentStatusResponseEvent;
        public event FiasMessageHandle<FiasCommonMessage> UnknownTypeMessageEvent;
        public event FiasMessageHandle<FiasCommonMessage> FiasUnknownTypeMessageEvent;

        public event FiasErrorHandle FiasErrorEvent;

        public event FiasChangeConnectionStateHandle FiasChangeConnectionStateEvent;

        public event FiasSendMessageHandle FiasSendMessageEvent;

        #endregion

        private bool _isRunning;

        private string _hostname;

        private int _port;

        private CancellationTokenSource _cancellationTokenSource;

        private CancellationToken _cancellationToken;

        public bool IsRunning
        {
            get => _isRunning;

            set
            {
                if (value != _isRunning)
                {
                    _isRunning = value;
                    _cancellationTokenSource.Cancel();
                }
            }
        }

        public string Hostname
        {
            get => _hostname;

            set
            {
                if (value != _hostname)
                {
                    _hostname = value;
                    _cancellationTokenSource.Cancel();
                }
            }
        }

        public int Port
        {
            get => _port;

            set
            {
                if (value != _port)
                {
                    _port = value;
                    _cancellationTokenSource.Cancel();
                }
            }
        }

        public CancellationToken CancellationToken => _cancellationToken;

        private FiasService() => RefreshCancellationToken();

        public FiasService(IOptionsSnapshot<FiasOptions> options) : this()
        {
            var defaultOptions = options.Value;
            _hostname = defaultOptions.Hostname;
            _port = defaultOptions.Port;
            _isRunning = defaultOptions.Running;
        }

        public void RefreshCancellationToken()
        {
            _cancellationTokenSource = new CancellationTokenSource();
            _cancellationToken = _cancellationTokenSource.Token;
        }

        public void Send(string message) => FiasSendMessageEvent?.Invoke(message);

        public void MessageEventInvoke(object message)
        {
            var type = message.GetType();
            
            if (type == typeof(FiasLinkStart))
                FiasLinkStartEvent?.Invoke((FiasLinkStart)message);
            else if (type == typeof(FiasLinkAlive))
                FiasLinkAliveEvent?.Invoke((FiasLinkAlive)message);
            else if (type == typeof(FiasLinkEnd))
                FiasLinkEndEvent?.Invoke((FiasLinkEnd)message);
            else if (type == typeof(FiasMessageDelete))
                FiasMessageDeleteEvent?.Invoke((FiasMessageDelete)message);
            else if (type == typeof(FiasWakeupClear))
                FiasWakeupClearEvent?.Invoke((FiasWakeupClear)message);
            else if (type == typeof(FiasWakeupRequest))
                FiasWakeupRequestEvent?.Invoke((FiasWakeupRequest)message);
            else if (type == typeof(FiasDatabaseResyncEnd))
                FiasDatabaseResyncEndEvent?.Invoke((FiasDatabaseResyncEnd)message);
            else if (type == typeof(FiasDatabaseResyncStart))
                FiasDatabaseResyncStartEvent?.Invoke((FiasDatabaseResyncStart)message);
            else if (type == typeof(FiasGuestBillBalance))
                FiasGuestBillBalanceEvent?.Invoke((FiasGuestBillBalance)message);
            else if (type == typeof(FiasGuestBillItem))
                FiasGuestBillItemEvent?.Invoke((FiasGuestBillItem)message);
            else if (type == typeof(FiasGuestChange))
                FiasGuestChangeEvent?.Invoke((FiasGuestChange)message);
            else if (type == typeof(FiasGuestCheckIn))
                FiasGuestCheckInEvent?.Invoke((FiasGuestCheckIn)message);
            else if (type == typeof(FiasGuestCheckOut))
                FiasGuestCheckOutEvent?.Invoke((FiasGuestCheckOut)message);
            else if (type == typeof(FiasKeyDataChange))
                FiasKeyDataChangeEvent?.Invoke((FiasKeyDataChange)message);
            else if (type == typeof(FiasKeyDelete))
                FiasKeyDeleteEvent?.Invoke((FiasKeyDelete)message);
            else if (type == typeof(FiasKeyReadResponse))
                FiasKeyReadResponseEvent?.Invoke((FiasKeyReadResponse)message);
            else if (type == typeof(FiasKeyRequest))
                FiasKeyRequestEvent?.Invoke((FiasKeyRequest)message);
            else if (type == typeof(FiasLinkConfiguration))
                FiasLinkConfigurationEvent?.Invoke((FiasLinkConfiguration)message);
            else if (type == typeof(FiasLocatorRetrieveResponse))
                FiasLocatorRetrieveResponseEvent?.Invoke((FiasLocatorRetrieveResponse)message);
            else if (type == typeof(FiasMessageText))
                FiasMessageTextEvent?.Invoke((FiasMessageText)message);
            else if (type == typeof(FiasMessageTextOnlineResponse))
                FiasMessageTextOnlineResponseEvent?.Invoke((FiasMessageTextOnlineResponse)message);
            else if (type == typeof(FiasNightAuditEnd))
                FiasNightAuditEndEvent?.Invoke((FiasNightAuditEnd)message);
            else if (type == typeof(FiasNightAuditStart))
                FiasNightAuditStartEvent?.Invoke((FiasNightAuditStart)message);
            else if (type == typeof(FiasPostingAnswer))
                FiasPostingAnswerEvent?.Invoke((FiasPostingAnswer)message);
            else if (type == typeof(FiasPostingList))
                FiasPostingListEvent?.Invoke((FiasPostingList)message);
            else if (type == typeof(FiasRemoteCheckOutResponse))
                FiasRemoteCheckOutResponseEvent?.Invoke((FiasRemoteCheckOutResponse)message);
            else if (type == typeof(FiasRoomEquipmentStatusResponse))
                FiasRoomEquipmentStatusResponseEvent?.Invoke((FiasRoomEquipmentStatusResponse)message);
        }

        public void UnknownTypeMessageEventInvoke(FiasCommonMessage message) =>
            UnknownTypeMessageEvent?.Invoke(message);

        public void ErrorEventInvoke(string errorMessage, Exception ex = null) =>
            FiasErrorEvent?.Invoke(errorMessage, ex);

        public void ChangeConnectionStateEventInvoke(bool isConnected, string hostname = null, int? port = null) =>
            FiasChangeConnectionStateEvent?.Invoke(isConnected, hostname, port);
    }
}