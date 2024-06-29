using HRManagement.Application.Contracts.Email;
using HRManagement.Infrastructure.EmailService;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace HRManagement.Infrastructure {


public static class InfrastructureServicesRegistration {

    public static IServiceCollection ConfigureInfrastructureServices(this IServiceCollection services, IConfiguration configuration) { 

        //dependency injection
        services.AddScoped<IEmailSender, EmailSender>();
        services.AddScoped(typeof(ILogger<>), typeof(Logger<>));


        return services;

    }

}






}

