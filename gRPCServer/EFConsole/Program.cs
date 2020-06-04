using EFConsole.Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using NLog;
using NLog.Config;
using NLog.Extensions.Logging;
using NLog.Targets;
using System;
using System.Threading.Tasks;

namespace EFConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            IHost host = CreateHostBuilder(args).Build();
            host.RunAsync();
            host.Services.GetRequiredService<EFDemoContext>().Set<User>().CountAsync();
            Console.ReadKey();
        }
        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                .ConfigureHostConfiguration(configurationBuilder =>
                {
                    //构造器设置

                }).ConfigureAppConfiguration(configurationBuilder =>
                {
                    //应用配置设置

                }).ConfigureLogging(loggingBuilder =>
                {
                    //日志设置
                    loggingBuilder.ClearProviders();
                    LoggingConfiguration nLogConfiguration = new LoggingConfiguration();
                    ConsoleTarget consoleTarget = new ConsoleTarget("logconsole");
                    FileTarget fileTarget = new FileTarget("logfile") { FileName = "Error.log" };
                    nLogConfiguration.AddRule(NLog.LogLevel.Trace, NLog.LogLevel.Fatal, consoleTarget);
                    nLogConfiguration.AddRule(NLog.LogLevel.Error, NLog.LogLevel.Fatal, fileTarget);
                    loggingBuilder.AddNLog(nLogConfiguration);
                })
                .ConfigureServices((hostBuilderContext, serviceCollection) =>
                {
                    //服务设置
                    serviceCollection.AddScoped<Logger>();
                    //DbContext服务设置
                    serviceCollection.AddDbContext<EFDemoContext>(dbContextOptionsBuilder =>
                    {
                        dbContextOptionsBuilder.UseSqlServer(hostBuilderContext.Configuration.GetConnectionString("dbStr"), sqlServerDbContextOptionsExtensions =>
                        {
                            sqlServerDbContextOptionsExtensions.EnableRetryOnFailure();
                        });
                    });
                });
        }
    }
}
