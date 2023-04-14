using Microsoft.Extensions.DependencyInjection;
using RMQMicroservice.Domain.Core.Bus;
using RMQMicroservice.Infra.Bus;
using System;

namespace RMQMicroservice.Infra.IOC
{
    public class DependencyContainer
    {
        public static void RegisterService(IServiceCollection services)
        {
            // Domain.Bus
            services.AddTransient<IEventBus, RabbitMQBus>();
        }

    }
}
