using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mall.Interface.Filters.ActionFilter;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;

namespace Mall.Interface
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //进程内IIS配置
            //services.Configure<IISServerOptions>(configuration => {
            //    //关闭身份验证
            //    configuration.AutomaticAuthentication = false;
            //});

            services.Configure<IISOptions>(iisOptions => {
                iisOptions.AutomaticAuthentication = false;
                iisOptions.ForwardClientCertificate = false;
            });

            services.AddCors(corsOptions=> {
                corsOptions.AddPolicy("default", corsPolicyBuilder => {
                    corsPolicyBuilder.AllowAnyOrigin();
                    corsPolicyBuilder.AllowAnyMethod();
                    corsPolicyBuilder.AllowAnyHeader();
                });
            });

            services.AddScoped<LogFilterAttribute>();
            services.AddScoped<ModelStateFilterAttribute>();
            services.AddScoped<TTFBFilterAttribute>();

            var mvcBuilder = services.AddControllers(mvcOptions =>
            {
                mvcOptions.Filters.Add<LogFilterAttribute>();
                mvcOptions.Filters.Add<ModelStateFilterAttribute>();
                mvcOptions.Filters.Add<TTFBFilterAttribute>();

            });

            //启用NewtonsoftJson
            mvcBuilder.AddNewtonsoftJson(mvcNewtonsoftJsonOptions=> {
                //JSON序列化默认格式
                mvcNewtonsoftJsonOptions.SerializerSettings.ContractResolver = new Newtonsoft.Json.Serialization.DefaultContractResolver();
            });

            mvcBuilder.ConfigureApiBehaviorOptions(apiBehaviorOptions =>
            {
                apiBehaviorOptions.SuppressModelStateInvalidFilter = true;
            });

            services.AddSwaggerGen(swaggerGenOptions =>
        {
            swaggerGenOptions.SwaggerDoc("v1", new OpenApiInfo { Title = "Mall API", Version = "v1" });
        });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler(exceptionHandlerOptions=> { 
                
                });
            }
            //app.UseHttpsRedirection();

            app.UseSwagger();

            //默认不启用Session
            //app.UseSession();

            app.UseSwaggerUI(swaggerUIOptions => {
                swaggerUIOptions.SwaggerEndpoint("/swagger/v1/swagger.json", "Mall API");
                swaggerUIOptions.RoutePrefix = string.Empty;
            });

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
