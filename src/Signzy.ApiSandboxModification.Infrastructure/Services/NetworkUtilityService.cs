using Signzy.ApiSandboxModification.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

using System.Text;
using System.Threading.Tasks;

namespace Signzy.ApiSandboxModification.Infrastructure.Services
{
    public class NetworkUtilityService : INetworkUtilityService
    {
        public async Task<string> GetUserIPAsync(CancellationToken cancellationToken)
        {
            string Str = "";
            Str = System.Net.Dns.GetHostName();
            var ipEntry = await System.Net.Dns.GetHostEntryAsync(Str);
            IPAddress[] addr = ipEntry.AddressList;
            var result= addr[addr.Length - 1].ToString();
            return result;
        }
    }
}
