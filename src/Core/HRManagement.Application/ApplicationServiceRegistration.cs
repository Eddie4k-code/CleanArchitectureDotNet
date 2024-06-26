using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace HRManagement.Application
{

    /* 
    
    Extend the IServiceCollection to create a method that allows us to add application services 
    returns services we want to add
    */
    public static class ApplicationServiceRegistration
    {
        public static IServiceCollection AddApplicationServies(this IServiceCollection services) {

            services.AddAutoMapper(Assembly.GetExecutingAssembly()); 
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

            return services;


        }
    }
}