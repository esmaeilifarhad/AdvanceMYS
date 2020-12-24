using DataLayer.Context;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.ConfigStartpp.Extension
{
    public static class IdentityExtension
    {
        public static IServiceCollection AddAthenticate(this IServiceCollection service)
        {
            service.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<MyContext>()
                .AddDefaultTokenProviders();

           
            return service;
        }
    }
}
