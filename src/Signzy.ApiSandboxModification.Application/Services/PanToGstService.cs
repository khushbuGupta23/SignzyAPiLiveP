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
    public class PanToGstService: IPanToGstService
    {
        private readonly IPanToGstRepository _panToGstRepository;

        public PanToGstService(IPanToGstRepository panToGstRepository)
        {
            _panToGstRepository = panToGstRepository;
        }
        public async Task<PanToGst> PanToGstAsync(EssentialsPAN essential, CancellationToken cancellationToken)
        {
            return await _panToGstRepository.PanToGstAsync(essential, cancellationToken);
        }
    }
}
