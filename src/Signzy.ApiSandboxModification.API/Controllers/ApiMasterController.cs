using Microsoft.AspNetCore.Mvc;
using Signzy.ApiSandboxModification.Application.Interfaces;
using Signzy.ApiSandboxModification.Domain.Entities;

namespace Signzy.ApiSandboxModification.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiMasterController : ControllerBase
    {
        private readonly IApiMasterService _apiMasterService;
        public ApiMasterController(IApiMasterService apiMasterService)
        {
            _apiMasterService = apiMasterService;
        }
        [HttpGet]
        [Route("GetAllAPIListAsync")]
        public async Task<IEnumerable<apiMasterModel>> GetAllAPIListAsync(CancellationToken cancellationToken)
        {
            return await _apiMasterService.GetAllAPIListAsync(cancellationToken);
        }
    }
}
