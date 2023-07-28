using Microsoft.Extensions.DependencyInjection;
using Signzy.ApiSandboxModification.Application.Interfaces;
using Signzy.ApiSandboxModification.Application.Services;

namespace Signzy.ApiSandboxModification.Application
{
    public static class DependencyInjection
    {

        public static void AddApplication(this IServiceCollection services)
        {

            services.AddScoped<IOrganizationService,OrganizationService>();
            services.AddScoped<IAddressProofService, AddressProofService>();
            services.AddScoped<IEmailValidationService, EmailValidationService>();
            services.AddScoped<ILoginService, LoginService>();
            services.AddScoped<IEmailVerificationService, EmailVeriFicationService>();


        }
    }
}
