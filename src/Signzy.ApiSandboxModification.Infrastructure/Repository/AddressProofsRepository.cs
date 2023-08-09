using Dapper;
using Newtonsoft.Json;
using Signzy.ApiSandboxModification.Domain.Entities;
using Signzy.ApiSandboxModification.Infrastructure.Data.Dapper;
using Signzy.ApiSandboxModification.Infrastructure.Interfaces;
using System;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading;

namespace Signzy.ApiSandboxModification.Infrastructure.Repository
{
    public class AddressProofsRepository : DapperRepository, IAddressProofsRepository
    {
        private readonly DapperCommand _logintoken =
         new DapperCommand("dbo.spGetLoginToken", CommandType.StoredProcedure);
        private readonly DapperCommand _otpRefNo =
         new DapperCommand("dbo.SpOTPReferenceNo", CommandType.StoredProcedure);
        private readonly DapperCommand _getElectricityBoard =
         new DapperCommand("dbo.spGetElectricityBoard", CommandType.StoredProcedure);

        public AddressProofsRepository(IDbConnectionFactory dbConnectionFactory, IDapperWrapper dapperWrapper) :
          base(dbConnectionFactory, dapperWrapper)
        {
        }


        public async Task<GenrateOtp?>GenerateOTPAsync(Essential essential, CancellationToken cancellationToken)
        {
            var res = await DapperWrapper.QueryAsync<TblAuth>(GetConnection(),
                      _logintoken, cancellationToken);
            string Token = res.First().token;
            string UserId = res.First().userId;
            essential.task = "generateOtp";
            RequestOTP requestOTP = new RequestOTP
            {
                essentials = essential,
                task = "mobile"
            };
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://preproduction.signzy.tech/api/v2/patrons/"+ UserId + "/phones"),
                Headers =
                            {
                            { "Accept-Language", "en-US,en;q=0.8" },
                            { "Accept", "*/*" },
                            { "Authorization", Token },
                            },
                Content = new StringContent(JsonConvert.SerializeObject(requestOTP), UnicodeEncoding.UTF8, "application/json")
            };
                    var response = await client.SendAsync(request);
                    response.EnsureSuccessStatusCode();
                    string body = await response.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<GenrateOtp>(body);
                    var parameters = new DynamicParameters();

                    parameters.Add(Mapping.Mapping.UserId, UserId);
                    parameters.Add(Mapping.Mapping.token, Token);
                    parameters.Add(Mapping.Mapping.CountryCode, result.essentials.countryCode);
                    parameters.Add(Mapping.Mapping.MobileNumber, result.essentials.mobileNumber);
                    parameters.Add(Mapping.Mapping.ReferenceId, result.result.referenceId);


            await DapperWrapper.ExecuteAsync(GetConnection(), _otpRefNo,parameters, cancellationToken);
            
            return result;
        }


        public async Task<SubmitOTP?> SubmitOtpAsync(Essentials1 essentials1, CancellationToken cancellationToken)
        {
            var res = await DapperWrapper.QueryAsync<TblAuth>(GetConnection(),_logintoken,cancellationToken);
            string Token = res.First().token;
            string UserId = res.First().userId;

            essentials1.task = "submitOtp";
            SubmitOTP submitOTP = new SubmitOTP
            {
                essentials = essentials1,
                task = "mobile"
            };
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://preproduction.signzy.tech/api/v2/patrons/" + UserId + "/phones"),
                Headers =
                            {
                                { "Accept-Language", "en-US,en;q=0.8" },
                                { "Accept", "*/*" },
                                { "Authorization", Token },
                            },
                Content = new StringContent(JsonConvert.SerializeObject(submitOTP), UnicodeEncoding.UTF8, "application/json")
            };
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            string body = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<SubmitOTP>(body);
        }


        //ElectricityDetail
        public async Task<IEnumerable<TblAuth>> ElectricityDetailAsync(CancellationToken cancellationToken)
        {

                    var res=await DapperWrapper.QueryAsync<TblAuth>(GetConnection(),
                             _logintoken, cancellationToken);
            return res;
        }


        public async Task<IEnumerable<ElectricityBoard>> ElectricityBoardAsync(CancellationToken cancellationToken)
        {
            var result = await DapperWrapper.QueryAsync<ElectricityBoard>(GetConnection(), _getElectricityBoard, cancellationToken);
            return result;
        }

    }
}
