using IdentityServer4.Models;
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
using System.Threading.Tasks;

namespace Signzy.ApiSandboxModification.Infrastructure.Repository
{
    public class OrganizationRepository :DapperRepository, IOrganizationRepository
    {
        private readonly DapperCommand _logintoken =
         new DapperCommand("dbo.spGetLoginToken", CommandType.StoredProcedure);

        public OrganizationRepository(IDbConnectionFactory dbConnectionFactory, IDapperWrapper dapperWrapper) :
          base(dbConnectionFactory, dapperWrapper)
        {
        }


        public async Task<UanNumber> SearchUanAsync(string uamNumber, CancellationToken cancellationToken)
        {
            var res = await DapperWrapper.QueryAsync<TblAuth>(GetConnection(),
                      _logintoken, cancellationToken);
            string Token = res.First().token;
            string UserId = res.First().userId;
            Dictionary<string, string> jsonValues = new Dictionary<string, string>();
            jsonValues.Add("UamNumber", uamNumber);

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://signzy.tech/api/v2/patrons/"+ UserId + "/udyogaadhaars"),
                Headers =
                        {
                            { "Accept-Language", "en-US,en;q=0.8" },
                            { "Accept", "*/*" },
                             { "Authorization", Token },
    },
                Content = new StringContent("{\"type\":\"..uam.\",\"essentials\":{\"uamNumber\":\"+UamNumber+\"}}")
                {
                    Headers =
        {
            ContentType = new MediaTypeHeaderValue("application/json")
        }
                }
            };
            var response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<UanNumber>(body);
        }

        public async Task<UdyamRegiResponse?> UdyamRegistrationAsync(string udyamNumber, CancellationToken cancellationToken)
        {
            var res = await DapperWrapper.QueryAsync<TblAuth>(GetConnection(), _logintoken,      cancellationToken);
                    string Token = res.First().token;
                    string UserId = res.First().userId;
            Dictionary<string, string> jsonValues = new Dictionary<string, string>();
            jsonValues.Add("udyamNumber", udyamNumber);
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://preproduction.signzy.tech/api/v2/patrons/" + UserId + "/udyamregistrations"),
                Headers =
                {
                    { "Accept-Language", "en-US,en;q=0.8" },
                    { "Accept", "*/*" },
                    { "Authorization", Token },
                },
                Content = new StringContent("{\"essentials\":{\"udyamNumber\":\""+udyamNumber+"\"}}")
                {
                    Headers =
                        {
                            ContentType = new MediaTypeHeaderValue("application/json")
                        }
                }
            };
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var body = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<UdyamRegiResponse>(body);
        }
    }
}
