using Bridge.Fias.FiasInterface;
using Bridge.Fias.SocketClient;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Bridge.Fias
{

    public static class FiasDependencyInjection
    {
        public static IServiceCollection AddFias(this IServiceCollection serviceCollection, Action<FiasOptions> delegateOptions)
        {
            if (delegateOptions == null)
                throw new ArgumentNullException(nameof(delegateOptions));

            var options = new FiasOptions();
            delegateOptions(options);
            serviceCollection.AddOptions<FiasOptions>().Configure(fiasOptions =>
            {
                fiasOptions.Hostname = options.Hostname;
                fiasOptions.Port = options.Port;
                fiasOptions.Running = options.Running;
            });

            serviceCollection.AddSingleton<IFiasService, FiasService>();
            serviceCollection.AddHostedService<FiasSocketClient>();

            return serviceCollection;
        }
    }
}