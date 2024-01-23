# Bridge.Fias
#### _Библиотека, разработанная на языке C# на платформе .NET Framework 4.8.1, для взаимодействия с Oracle® Hospitality Hotel Property Interface IFC8 FIAS Release 2.20.25._

[Документация Oracle® Hospitality Hotel Property Interface IFC8 FIAS Release 2.20.25](https://github.com/ivankopanyov/Bridge.Fias/blob/master/HGBU-HPI-IFC8-FIAS-Specification2.25.pdf)

#### _Пример_

```cs
using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Bridge.Fias.Entities;
using Bridge.Fias;
using System.Threading.Tasks;
using System.Threading;
using Bridge.Fias.FiasInterface;
using Microsoft.Extensions.Logging;

namespace Bridge.Example
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            IHostBuilder builder = Host.CreateDefaultBuilder(args);
            builder.ConfigureServices((hostBuilderContext, services) =>
            {
                services.AddFias(fiasOptions =>
                {
                    fiasOptions.Hostname = "localhost";
                    fiasOptions.Port = 5010;
                    fiasOptions.Running = false;
                });

                services.AddHostedService<FiasHandler>();
            });

            using (IHost host = builder.Build())
            {
                host.Run();
            }
        }
    }

    internal class FiasHandler : BackgroundService
    {
        private readonly IFiasService _fiasService;

        private readonly ILogger _logger;

        public FiasHandler(IFiasService fiasService, ILogger<FiasHandler> logger)
        {
            _fiasService = fiasService;
            _logger = logger;
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _fiasService.FiasLinkStartEvent += (message) =>
            {
                var linkDescription = new FiasLinkDescription()
                {
                    DateTime = DateTime.Now,
                    VendorSystemsVersion = "1.0.3.0",
                    InterfaceFamily = FiasInterfaceTypes.PayTV
                }.ToString();

                _fiasService.Send(linkDescription);

                var guestCheckInOptions = new FiasLinkRecord(Fias.Entities.FiasOptions.All<FiasGuestCheckInOptions>()).ToString();
                _fiasService.Send(guestCheckInOptions);

                var guestCheckOutOptions = new FiasLinkRecord(Fias.Entities.FiasOptions.All<FiasGuestCheckOutOptions>()).ToString();
                _fiasService.Send(guestCheckOutOptions);

                var guestChangeOptions = new FiasLinkRecord(Fias.Entities.FiasOptions.All<FiasGuestChangeOptions>()).ToString();
                _fiasService.Send(guestChangeOptions);

                var linkAlive = new FiasLinkAlive() { DateTime = DateTime.Now }.ToString();
                _fiasService.Send(linkAlive);

                _logger.LogInformation($"--> {message.Source}\n<-- {linkDescription}\n<-- {guestCheckInOptions}\n<-- {guestCheckOutOptions}\n<-- {guestChangeOptions}\n<-- {linkAlive}");

                return Task.CompletedTask;
            };

            _fiasService.FiasLinkAliveEvent += (message) =>
            {
                _logger.LogInformation($"--> {message.Source}");
                return Task.CompletedTask;
            };

            _fiasService.FiasLinkEndEvent += (message) =>
            {
                _logger.LogError($"Fias disconnected the connection.\n--> {message.Source}");

                _fiasService.IsRunning = false;
                _fiasService.IsRunning = true;

                return Task.CompletedTask;
            };

            _fiasService.FiasChangeConnectionStateEvent += (isConnect, hostname, port) =>
            {
                string host = $"{hostname}:{port}";

                if (isConnect)
                    _logger.LogInformation($"Сonnection with {host} successful.");
                else
                    _logger.LogError($"Сonnection with {host} is failed.");

                return Task.CompletedTask;
            };

            _fiasService.FiasErrorEvent += (message, ex) =>
            {
                _logger.LogError($"{message ?? ex.Message}");
                return Task.CompletedTask;
            };

            _fiasService.FiasGuestCheckInEvent += (message) =>
            {
                _logger.LogInformation($"--> {message.Source}");
                return Task.CompletedTask;
            };

            _fiasService.IsRunning = true;

            return Task.CompletedTask;
        }
    }
}
```
