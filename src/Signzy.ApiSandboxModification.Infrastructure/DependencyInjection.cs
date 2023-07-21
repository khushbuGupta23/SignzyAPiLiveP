using Microsoft.Extensions.DependencyInjection;
using Nippon.PaintPartner.Infrastructure.Data;
using Nippon.PaintPartner.Infrastructure.Data.Dapper;
using Nippon.PaintPartner.Infrastructure.Interfaces;

using Nippon.PaintPartner.Infrastructure.Repository;

using Nippon.PaintPartner.Infrastructure.Services;

namespace Nippon.PaintPartner.Infrastructure
{
    public static class DependencyInjection
    {
        public static void AddInfrastructure(this IServiceCollection services)
        {  
            services.AddScoped<IAddressRepository, AddressRepository>();
            services.AddScoped<IDbConnectionFactory, SqlConnectionFactory>();
            services.AddScoped<IDapperWrapper, DapperWrapper>();
            services.AddScoped<IActivityLogRepository, ActivityLogRepository>();
        }
    }
}
