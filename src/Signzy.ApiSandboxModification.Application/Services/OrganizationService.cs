
using Signzy.ApiSandboxModification.Application.Interfaces;
using Signzy.ApiSandboxModification.Domain.Entities;
using Signzy.ApiSandboxModification.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signzy.ApiSandboxModification.Application.Services
{
    public class OrganizationService : IOrganizationService
    {
        private readonly IOrganizationRepository _organizationRepository;

        public OrganizationService(IOrganizationRepository organizationRepository)
        {
            _organizationRepository = organizationRepository;
        }

    
        public async Task<UanNumber> SearchUanAsync(string uamNumber, CancellationToken cancellationToken)
        {
            return await _organizationRepository.SearchUanAsync(uamNumber, cancellationToken);
        }
        public async Task<UdyamRegiResponse> UdyamRegistrationAsync(string udyamNumber, CancellationToken cancellationToken)
        {
            return await _organizationRepository.UdyamRegistrationAsync(udyamNumber, cancellationToken);
        }
    }
}
