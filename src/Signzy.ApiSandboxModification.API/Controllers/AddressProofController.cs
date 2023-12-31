﻿using Microsoft.AspNetCore.Mvc;
using Signzy.ApiSandboxModification.Application.Interfaces;
using Signzy.ApiSandboxModification.Application.Services;
using Signzy.ApiSandboxModification.Domain.Entities;

namespace Signzy.ApiSandboxModification.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressProofController : ControllerBase
    {
        private readonly IAddressProofService _addressProofService;
        public AddressProofController(IAddressProofService addressProofService)
        {
            _addressProofService = addressProofService;
        }


        //ElectricityDetail
        [HttpPost]
        [Route("ElectricityDetailAsync")]
        public async Task<ElectricityDetail> ElectricityDetailAsync(string consumerNo, string electricityProvider, string? installationNumber, string? mobileNo, CancellationToken cancellationToken)
        {
            return await _addressProofService.ElectricityDetailAsync(consumerNo, electricityProvider, installationNumber, mobileNo, cancellationToken);
        }

        [HttpGet]
        [Route("ElectricityBoardAsync")]
        public async Task<IEnumerable<ElectricityBoard>> ElectricityBoardAsync(CancellationToken cancellationToken)
        {
            return await _addressProofService.ElectricityBoardAsync(cancellationToken);
        }


        [HttpPost]
        [Route("GenerateOTPAsync")]
        public async Task<GenrateOtp> GenerateOTPAsync([FromQuery] Essential essential, CancellationToken cancellationToken)
        {
            return await _addressProofService.GenerateOTPAsync(essential, cancellationToken);
        }
        [HttpPost]
        [Route("SubmitOtpAsync")]
        public async Task<SubmitOTP?> SubmitOtpAsync([FromQuery] Essentials1 essentials, CancellationToken cancellationToken)
        {
            return await _addressProofService.SubmitOtpAsync(essentials, cancellationToken);
        }

    }
}
