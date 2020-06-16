using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mall.AppConfig
{
    public static class MallAppConfigExtension
    {
        public static void AddAppConfiguration(this IServiceCollection servicesCollection)
        {
            servicesCollection.AddSingleton<AppConfiguration>();
        }
    }
}
