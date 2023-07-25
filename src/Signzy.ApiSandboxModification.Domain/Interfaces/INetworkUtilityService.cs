
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signzy.ApiSandboxModification.Application.Interfaces
{
    public interface INetworkUtilityService
    {
        public Task<string> GetUserIPAsync(CancellationToken cancellationToken);
    }
}
