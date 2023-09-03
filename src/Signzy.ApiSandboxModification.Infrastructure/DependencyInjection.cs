using Microsoft.Extensions.DependencyInjection;
using Signzy.ApiSandboxModification.Infrastructure.Data;
using Signzy.ApiSandboxModification.Infrastructure.Data.Dapper;
using Signzy.ApiSandboxModification.Infrastructure.Interfaces;
using Signzy.ApiSandboxModification.Infrastructure.Repository;

namespace Signzy.ApiSandboxModification.Infrastructure
{
    public static class DependencyInjection
    {
        public static void AddInfrastructure(this IServiceCollection services)
        {  

            services.AddScoped<IGstrInitiationsRepository, GstrInitiationsRepository>();
            services.AddScoped<IApiMasterRepository, ApiMasterRepository>();
            services.AddScoped<IPanToGstRepository, PanToGstRepository>();
            services.AddScoped<IOrganizationRepository, OrganizationRepository>();
            services.AddScoped<IAddressProofsRepository, AddressProofsRepository>();
            services.AddScoped<ILoginRepository, LoginRepository>();
            services.AddScoped<IDapperWrapper, DapperWrapper>();
            services.AddScoped<IEmailValidationRepository, EmailValidationRepository>();
            services.AddScoped< IDbConnectionFactory, SqlConnectionFactory>();
            services.AddScoped<IEmailVerificationRepository, EmailVerificationRepository>();
            services.AddScoped<IUserRepository,UserRepository>();
        }
    }
}
