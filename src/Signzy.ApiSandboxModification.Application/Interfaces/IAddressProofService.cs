using Signzy.ApiSandboxModification.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signzy.ApiSandboxModification.Application.Interfaces
{
    public interface IAddressProofService
    {
        public Task<GenrateOtp> GenerateOTPAsync(Essential essential, CancellationToken cancellationToken);
        public Task<SubmitOTP?> SubmitOtpAsync(Essentials1 essentials, CancellationToken cancellationToken);
    }
}
