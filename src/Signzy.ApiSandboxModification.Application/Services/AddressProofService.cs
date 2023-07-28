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
    public class AddressProofService : IAddressProofService
    {
        private readonly IAddressProofsRepository _addressProofsRepository;

        public AddressProofService(IAddressProofsRepository addressProofsRepository)
        {
            _addressProofsRepository = addressProofsRepository;
        }
        public async Task<GenrateOtp> GenerateOTPAsync(Essential essential, CancellationToken cancellationToken)
        {
            return await _addressProofsRepository.GenerateOTPAsync(essential, cancellationToken);
        }
        public async Task<SubmitOTP?> SubmitOtpAsync(Essentials1 essentials, CancellationToken cancellationToken)
        {
            return await _addressProofsRepository.SubmitOtpAsync(essentials, cancellationToken);
        }
    }
}
