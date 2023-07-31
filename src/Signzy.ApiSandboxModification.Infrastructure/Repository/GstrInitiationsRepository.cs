using Newtonsoft.Json;
using Signzy.ApiSandboxModification.Domain.Entities;
using Signzy.ApiSandboxModification.Infrastructure.Data.Dapper;
using Signzy.ApiSandboxModification.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Signzy.ApiSandboxModification.Infrastructure.Repository
{
    public class GstrInitiationsRepository:DapperRepository ,IGstrInitiationsRepository
    {
        private readonly DapperCommand _logintoken =
          new DapperCommand("dbo.spGetLoginToken", CommandType.StoredProcedure);
        public GstrInitiationsRepository(IDbConnectionFactory dbConnectionFactory, IDapperWrapper dapperWrapper) : base(dbConnectionFactory, dapperWrapper)
        {
        }


        public async Task<GstrInitiations> GstrInitiationsAsync(EssentialsGSTR essential , CancellationToken cancellationToken)
        {

            var res = await DapperWrapper.QueryAsync<TblAuth>(GetConnection(),
                    _logintoken, cancellationToken);
            string Token = res.First().token;
            string UserId = res.First().userId;
            GstrInput requestGstOtp = new GstrInput
            {
                essentials = essential,
                task = "getOtp"
            };
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://preproduction.signzy.tech/api/v2/patrons/" + UserId + "/gstrinitiations"),
                Headers =
                                {
                                    { "Accept-Language", "en-US,en;q=0.8" },
                                    { "Accept", "*/*" },
                                    { "Authorization", Token },
                                },
                Content = new StringContent(JsonConvert.SerializeObject(requestGstOtp), UnicodeEncoding.UTF8, "application/json")
            };
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var body= await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<GstrInitiations>(body);
        }

    }
}
