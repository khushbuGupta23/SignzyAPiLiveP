using Signzy.ApiSandboxModification.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signzy.ApiSandboxModification.Infrastructure.Interfaces
{
    public interface IOrganizationRepository
    {
        public Task<UanNumber> SearchUanAsync(string uamNumber, CancellationToken cancellationToken);
        public Task<UdyamRegiResponse> UdyamRegistrationAsync(string udyamNumber, CancellationToken cancellationToken);
    }
}
