using Microsoft.AspNetCore.Mvc;
using Signzy.ApiSandboxModification.Application.Interfaces;
using Signzy.ApiSandboxModification.Domain.Entities;

namespace Signzy.ApiSandboxModification.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class GstrInitiationsController : ControllerBase
    {
        private readonly IGstrInitiationsService _gstrInitiationsService;
        public GstrInitiationsController(IGstrInitiationsService gstrInitiationsService)
        {
            _gstrInitiationsService = gstrInitiationsService;
        }
        [HttpPost]
        [Route("GstrInitiationsAsync")]
        public async Task<GstrInitiations> GstrInitiationsAsync([FromQuery] EssentialsGSTR essential, CancellationToken cancellationToken)
        {
            return await _gstrInitiationsService.GstrInitiationsAsync(essential, cancellationToken);
        }

    }
}
