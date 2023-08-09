using Signzy.ApiSandboxModification.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signzy.ApiSandboxModification.Infrastructure.Interfaces
{
    public interface IAddressProofsRepository
    {
        public Task<GenrateOtp> GenerateOTPAsync(Essential Essential, CancellationToken cancellationToken);
        public Task<SubmitOTP?> SubmitOtpAsync(Essentials1 essentials, CancellationToken cancellationToken);
        public Task<IEnumerable<TblAuth>> ElectricityDetailAsync(CancellationToken cancellationToken);
        public Task<IEnumerable<ElectricityBoard>> ElectricityBoardAsync(CancellationToken cancellationToken);
    }
}
