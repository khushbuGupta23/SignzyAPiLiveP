using Signzy.ApiSandboxModification.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signzy.ApiSandboxModification.Application.Interfaces
{
    public interface IPanToGstService
    {
        public Task<PanToGst> PanToGstAsync(EssentialsPAN essential, CancellationToken cancellationToken);
    }
}
