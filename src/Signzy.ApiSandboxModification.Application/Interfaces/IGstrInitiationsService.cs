using Signzy.ApiSandboxModification.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signzy.ApiSandboxModification.Application.Interfaces
{
    public interface IGstrInitiationsService
    {
        public Task<GstrInitiations> GstrInitiationsAsync(EssentialsGSTR essential, CancellationToken cancellationToken);
    }
}
