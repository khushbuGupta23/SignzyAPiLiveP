using Microsoft.Extensions.DependencyInjection;
using Signzy.ApiSandboxModification.Application.Interfaces;
using Signzy.ApiSandboxModification.Application.Services;
using Signzy.ApiSandboxModification.Application.Services.Addressproof;
using Signzy.ApiSandboxModification.Application.Services.APIMasterService;
using Signzy.ApiSandboxModification.Application.Services.SignzyLoginService;
using Signzy.ApiSandboxModification.Application.Services.UserDetail;

namespace Signzy.ApiSandboxModification.Application
{
    public static class DependencyInjection
    {

        public static void AddApplication(this IServiceCollection services)
        {

            services.AddScoped<IApiMasterService, ApiMasterService>();
            services.AddScoped<IAddressProofService,AddressProofService>();
            services.AddScoped<IGstrInitiationsService, GstrInitiationsService>();
            services.AddScoped<IPanToGstService, PanToGstService>();
            services.AddScoped<IOrganizationService,OrganizationService>(); 
            services.AddScoped<IEmailValidationService, EmailValidationService>();
            services.AddScoped<ILoginService,LoginService>();
            services.AddScoped<IEmailVerificationService, EmailVeriFicationService>();
            services.AddScoped<IUserService, UserService>();
            //services.AddScoped<IEmailService, EmailService>();


        }
    }
}
