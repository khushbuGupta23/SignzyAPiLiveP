using Microsoft.Extensions.DependencyInjection;
using Nippon.PaintPartner.Application.Interfaces;
using Nippon.PaintPartner.Application.Services;

using Nippon.PaintPartner.Infrastructure.Services;

namespace Nippon.PaintPartner.Application
{
    public static class DependencyInjection
    {

        public static void AddApplication(this IServiceCollection services)
        {
            

            services.AddScoped<IAddressService, AddressService>();
            services.AddScoped<IActivityLogService, ActivityLogService>();




        }
    }
}
