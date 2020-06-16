using Mall.Repository.Structure;
using Mall.Repostitory.Structure;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mall.RespositoryImpl
{
    public static class MallRespositorytExtension
    {
        public static void AddRespositoryt(this IServiceCollection servicesCollection)
        {
            servicesCollection.AddScoped<ICustomerResponsitory, CustomerResponsitorpy>();
        }
    }
}
