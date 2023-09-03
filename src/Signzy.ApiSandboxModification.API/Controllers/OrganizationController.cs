using Microsoft.AspNetCore.Mvc;
using Signzy.ApiSandboxModification.Application.Interfaces;
using Signzy.ApiSandboxModification.Domain.Entities.OrganizationModel;

namespace Signzy.ApiSandboxModification.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrganizationController : Controller
    {
        private readonly IOrganizationService _organizationService;
        public OrganizationController(IOrganizationService organizationService)
        {
            _organizationService = organizationService;
        }

        [HttpPost]
        [Route("SearchUanAsync")]
        public async Task<UanNumber> SearchUanAsync([FromQuery] EssentialsUAN essentials1, CancellationToken cancellationToken)
        {
            return await _organizationService.SearchUanAsync(essentials1, cancellationToken);
        }


        [HttpPost]
        [Route("UdyamRegistrationAsync")]
        public async Task<UdyamRegiResponse>UdyamRegistrationAsync(string udyamNumber, CancellationToken cancellationToken)
        {
            return await _organizationService.UdyamRegistrationAsync(udyamNumber, cancellationToken);
        }


        [HttpPost]
        [Route("ShopAndEstablishmentasync")]
        public async Task<ShopAndEstablishmentModel> ShopAndEstablishmentasync(string registrationNumber, string state, CancellationToken cancellationToken)
        {
            return await _organizationService.ShopAndEstablishmentasync(registrationNumber, state, cancellationToken);
        }


        [HttpGet]
        [Route("GetAllStateListAsync")]
        public async Task<IEnumerable<StateMasterModel>> GetAllStateListAsync(CancellationToken cancellationToken)
        {
            return await _organizationService.GetAllStateListAsync(cancellationToken);
        }

        [HttpPost]
        [Route("EmpNameSearchV2Async")]
        public async Task<EmpNameSerachV2Model>EmpNameSearchV2Async([FromQuery] EssentialsENSV essential, CancellationToken cancellationToken)
        {
            return await _organizationService.EmpNameSearchV2Async(essential, cancellationToken);
        }

        [HttpPost]
        [Route("ICAIAsync")]
        public async Task<ICAIModel> ICAIAsync([FromQuery] EssentialsICAI essential, CancellationToken cancellationToken)
        {
            return await _organizationService.ICAIAsync(essential, cancellationToken);
        }
    }
}
