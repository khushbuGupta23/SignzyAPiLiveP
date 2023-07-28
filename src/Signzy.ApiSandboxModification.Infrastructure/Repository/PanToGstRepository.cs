using Newtonsoft.Json;
using Signzy.ApiSandboxModification.Domain.Entities;
using Signzy.ApiSandboxModification.Infrastructure.Data.Dapper;
using Signzy.ApiSandboxModification.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signzy.ApiSandboxModification.Infrastructure.Repository
{
    public class PanToGstRepository: DapperRepository, IPanToGstRepository
    {
        private readonly DapperCommand _logintoken =
          new DapperCommand("dbo.spGetLoginToken", CommandType.StoredProcedure);
        public PanToGstRepository(IDbConnectionFactory dbConnectionFactory, IDapperWrapper dapperWrapper) : base(dbConnectionFactory, dapperWrapper)
        {
        }
        public async Task<PanToGst?>PanToGstAsync(EssentialsPAN essential, CancellationToken cancellationToken)
        {
            var res = await DapperWrapper.QueryAsync<TblAuth>(GetConnection(),
                     _logintoken, cancellationToken);
            string Token = res.First().token;
            string UserId = res.First().userId;
            PanToGstResponse requestGST = new PanToGstResponse
            {
                essentials = essential,
                task = "panSearch"
            };
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://preproduction.signzy.tech/api/v2/patrons/" + UserId + "/gstns"),
                Headers =
                            {
                                { "Accept-Language", "en-US,en;q=0.8" },
                                { "Accept", "*/*" },
                                { "Authorization",Token },
                            },
                Content = new StringContent(JsonConvert.SerializeObject(requestGST), UnicodeEncoding.UTF8, "application/json")
            };
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var body = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<PanToGst>(body);
        }
    }
}
