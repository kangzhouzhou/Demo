using Mall.Persistent;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Mall.PersistentImpl
{
    /// <summary>
    /// 扩展服务
    /// </summary>
    public static class MallPersistentExtension 
    {
        /// <summary>
        /// 持久化数据
        /// </summary>
        /// <param name="servicesCollection"></param>
        public static void AddPersistent(this IServiceCollection servicesCollection,string connectionStr)
        {
            servicesCollection.AddScoped(typeof(IPersistent<>), typeof(DbPersistent<>));
            servicesCollection.AddScoped(typeof(InitPersitent), typeof(DbInitPersitent));
            servicesCollection.AddDbContext<MallDbContext>(contextOptionsBuilder=> {
                contextOptionsBuilder.UseSqlServer(connectionStr, sqlServerOptions => {
                    sqlServerOptions.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
                });
            });
            InitPersitent initPersitent = servicesCollection.BuildServiceProvider().GetRequiredService<InitPersitent>();
            initPersitent.Init();
        }
    }
}
