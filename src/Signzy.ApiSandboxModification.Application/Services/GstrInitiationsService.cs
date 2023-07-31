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
    public class GstrInitiationsService :IGstrInitiationsService
    {
        private readonly IGstrInitiationsRepository _gstrInitiationsRepository;

        public GstrInitiationsService(IGstrInitiationsRepository gstrInitiationsRepository)
        {
            _gstrInitiationsRepository = gstrInitiationsRepository;
        }
        public async Task<GstrInitiations> GstrInitiationsAsync(EssentialsGSTR essential, CancellationToken cancellationToken)
        {
            return await _gstrInitiationsRepository.GstrInitiationsAsync(essential, cancellationToken);
        }

    }
}
