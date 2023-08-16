using IdentityServer4.Models;
using Newtonsoft.Json;
using Signzy.ApiSandboxModification.Application.Interfaces;
using Signzy.ApiSandboxModification.Domain.Entities;
using Signzy.ApiSandboxModification.Infrastructure.Data.Dapper;
using Signzy.ApiSandboxModification.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Signzy.ApiSandboxModification.Application.Services.Addressproof
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

        //ElectricityDetail
        public async Task<ElectricityDetail> ElectricityDetailAsync(string consumerNo, string electricityProvider, string installationNumber, string mobileNo, CancellationToken cancellationToken)
        {
            var res = await _addressProofsRepository.ElectricityDetailAsync(cancellationToken);
            string Token = res.First().token;
            string UserId = res.First().userId;
            Dictionary<string, string> jsonValues = new Dictionary<string, string>();
            jsonValues.Add("consumerNo", consumerNo);
            jsonValues.Add("electricityProvider", electricityProvider);
            jsonValues.Add("installationNumber", installationNumber);
            jsonValues.Add("mobileNo", mobileNo);
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://preproduction.signzy.tech/api/v2/patrons/" + UserId + "/electricitybills"),
                Headers =
                                    {
                                        { "Accept-Language", "en-US,en;q=0.8" },
                                        { "Accept", "*/*" },
                                        { "Authorization", Token },
                                    },
                Content = new StringContent("{\"essentials\":{\"consumerNo\":\"" + consumerNo + "\",\"electricityProvider\":\"" + electricityProvider + "\",\"installationNumber\":\"" + installationNumber + "\"}}")
                {
                    Headers =
        {
            ContentType = new MediaTypeHeaderValue("application/json")
        }
                }
            };
            var response = await client.SendAsync(request);
            var body = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ElectricityDetail>(body);
        }

        public async Task<IEnumerable<ElectricityBoard>> ElectricityBoardAsync(CancellationToken cancellationToken)
        {
            return await _addressProofsRepository.ElectricityBoardAsync(cancellationToken);
        }
    }
}
