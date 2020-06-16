using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mall.AppConfig
{
    public class AppConfiguration
    {
        public AppConfiguration(IConfiguration configuration)
        {
            IConfigurationSection config= configuration.GetSection("AppConfiguration");
            JwtSecret = config[nameof(JwtSecret)];
        }

        public string JwtSecret { get; private set; }
    }
}
