﻿using Microsoft.AspNetCore.Mvc;
using Signzy.ApiSandboxModification.Application.Interfaces;
using Signzy.ApiSandboxModification.Domain.Entities;

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
        public async Task<UanNumber> SearchUanAsync(string uamNumber, CancellationToken cancellationToken)
        {
            return await _organizationService.SearchUanAsync(uamNumber, cancellationToken);
        }

        [HttpPost]
        [Route("UdyamRegistrationAsync")]
        public async Task<UdyamRegiResponse>UdyamRegistrationAsync(string udyamNumber, CancellationToken cancellationToken)
        {
            return await _organizationService.UdyamRegistrationAsync(udyamNumber, cancellationToken);
        }


    }
}
