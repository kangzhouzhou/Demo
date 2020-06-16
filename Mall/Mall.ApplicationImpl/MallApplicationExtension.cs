using Mall.Application;
using Mall.Assembler;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mall.ApplicationImpl
{
    public static class MallApplicationExtension
    {
        public static void AddApplication(this IServiceCollection servicesCollection)
        {
            servicesCollection.AddScoped<IdentityAssembler>();
            servicesCollection.AddScoped<IdentityService, IdentityServiceImpl>();
        }
    }
}
