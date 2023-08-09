using Signzy.ApiSandboxModification.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signzy.ApiSandboxModification.Application.Interfaces
{
    public interface IOrganizationService
    {
        public Task<UanNumber> SearchUanAsync(EssentialsUAN essentials1, CancellationToken cancellationToken);
        public Task<UdyamRegiResponse> UdyamRegistrationAsync(string udyamNumber, CancellationToken cancellationToken);
    }
}
