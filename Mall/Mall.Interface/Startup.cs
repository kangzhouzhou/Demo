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
            services.AddScoped<LogFilterAttribute>();
            services.AddScoped<ModelStateFilterAttribute>(); 
            services.AddScoped<TTFBFilterAttribute>();

            var mvcBuilder = services.AddControllers(mvcOptions =>
            {
                mvcOptions.Filters.Add<LogFilterAttribute>();
                mvcOptions.Filters.Add<ModelStateFilterAttribute>();
                mvcOptions.Filters.Add<TTFBFilterAttribute>();
            });

            //ÆôÓÃNewtonsoftJson
            mvcBuilder.AddNewtonsoftJson();

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

            app.UseHttpsRedirection();

            app.UseSwagger();

            app.UseSwaggerUI(swaggerUIOptions => {
                swaggerUIOptions.SwaggerEndpoint("/swagger/v1/swagger.json", "Mall API");
               // swaggerUIOptions.RoutePrefix = string.Empty;
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
