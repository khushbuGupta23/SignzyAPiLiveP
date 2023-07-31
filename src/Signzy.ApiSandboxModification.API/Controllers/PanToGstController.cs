using Microsoft.AspNetCore.Mvc;
using Signzy.ApiSandboxModification.Application.Interfaces;
using Signzy.ApiSandboxModification.Domain.Entities;

namespace Signzy.ApiSandboxModification.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PanToGstController : ControllerBase
    {
        private readonly IPanToGstService _panToGstService;
        public PanToGstController(IPanToGstService panToGstService)
        {
            _panToGstService = panToGstService;
        }
        [HttpPost]
        [Route("PanToGstAsync")]
        public async Task<PanToGst> PanToGstAsync([FromQuery] EssentialsPAN essential, CancellationToken cancellationToken)
        {
            return await _panToGstService.PanToGstAsync(essential, cancellationToken);
        }

    }
}
