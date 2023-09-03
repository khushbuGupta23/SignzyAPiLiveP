using Signzy.ApiSandboxModification.Application.Interfaces;
using Signzy.ApiSandboxModification.Domain.Entities;
using Signzy.ApiSandboxModification.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signzy.ApiSandboxModification.Application.Services.APIMasterService
{
    public class ApiMasterService : IApiMasterService
    {
        private readonly IApiMasterRepository _apiRepository;

        public ApiMasterService(IApiMasterRepository apiRepository)
        {
            _apiRepository = apiRepository;
        }
        public async Task<IEnumerable<apiMasterModel>> GetAllAPIListAsync(CancellationToken cancellationToken)
        {
            return await _apiRepository.GetAllAPIListAsync(cancellationToken);
        }
    }
}
