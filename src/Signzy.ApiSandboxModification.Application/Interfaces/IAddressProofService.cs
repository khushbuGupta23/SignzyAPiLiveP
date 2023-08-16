using Signzy.ApiSandboxModification.Domain.Entities;
using System;
using System.Threading.Tasks;


namespace Signzy.ApiSandboxModification.Application.Interfaces
{
    public interface IAddressProofService
    {
        public Task<GenrateOtp> GenerateOTPAsync(Essential essential, CancellationToken cancellationToken);
        public Task<SubmitOTP?> SubmitOtpAsync(Essentials1 essentials, CancellationToken cancellationToken);
        public Task<ElectricityDetail> ElectricityDetailAsync(string consumerNo, string electricityProvider, string installationNumber, string mobileNo, CancellationToken cancellationToken);
        public Task<IEnumerable<ElectricityBoard>> ElectricityBoardAsync(CancellationToken cancellationToken);
    }
}
