using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mall.AppConfig;
using Mall.ApplicationImpl;
using Mall.PersistentImpl;
using Mall.RespositoryImpl;
using Mall.Utility;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using NLog;
using NLog.Config;
using NLog.Extensions.Logging;
using NLog.Targets;

namespace Mall.Interface
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureLogging(loggingBuilder =>
                {
                    //loggingBuilder.ClearProviders();
                    //NLog
                    LoggingConfiguration logConfiguration = new LoggingConfiguration();
                    FileTarget fileTarget = new FileTarget() { FileName = "All.log" };
                    fileTarget.ArchiveNumbering = ArchiveNumberingMode.DateAndSequence;
                    fileTarget.ArchiveDateFormat = "yyyy-MM-dd";
                    logConfiguration.AddRule(NLog.LogLevel.Trace, NLog.LogLevel.Fatal, fileTarget);
                    loggingBuilder.AddNLog(logConfiguration);
                }).
                ConfigureServices((hostBuilderContext,servicesCollection) => {

                    servicesCollection.AddAppConfiguration();
                    //³Ö¾Ã»¯
                    servicesCollection.AddPersistent(hostBuilderContext.Configuration.GetConnectionString("DbConnection"));

                    servicesCollection.AddRespositoryt();

                    servicesCollection.AddApplication();
                })
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseKestrel(kestrelServerOptions => {
                        kestrelServerOptions.Listen(new System.Net.IPAddress(new byte[] { 127, 0, 0, 1 }), 5001, listenOptions =>
                             {
                                 listenOptions.Protocols = Microsoft.AspNetCore.Server.Kestrel.Core.HttpProtocols.Http2;
                                 listenOptions.UseHttps();
                             });
                        kestrelServerOptions.Listen(new System.Net.IPAddress(new byte[] { 127, 0, 0, 1 }), 5000, listenOptions =>
                        {
                            listenOptions.Protocols = Microsoft.AspNetCore.Server.Kestrel.Core.HttpProtocols.Http2;
                        });
                    });
                    webBuilder.UseStartup<Startup>();
                });
    }
}
