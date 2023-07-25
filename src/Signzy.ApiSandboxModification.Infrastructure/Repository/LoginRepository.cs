using Dapper;
using Newtonsoft.Json;
using Signzy.ApiSandboxModification.Domain.Entities;
using Signzy.ApiSandboxModification.Infrastructure.Data.Dapper;
using Signzy.ApiSandboxModification.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Signzy.ApiSandboxModification.Infrastructure.Repository
{
    public class LoginRepository : DapperRepository, ILoginRepository
    {

        private readonly DapperCommand _loginauth =
           new DapperCommand("dbo.spLoginAuth", CommandType.StoredProcedure);

        public LoginRepository(IDbConnectionFactory dbConnectionFactory, IDapperWrapper dapperWrapper) :
          base(dbConnectionFactory, dapperWrapper)
        {
        }
        public async Task<LoginAuth> LoginVerificationAsync(string username,string password,CancellationToken cancellationToken)
        {
            Dictionary<string, string> jsonValues = new Dictionary<string, string>();
            jsonValues.Add("username", username);
            jsonValues.Add("password", password);
            var client = new HttpClient();
           
            var request = new HttpRequestMessage    
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://preproduction.signzy.tech/api/v2/patrons/login"),
                Headers =
                        {
                            { "Accept-Language", "en-US,en;q=0.8" },
                            { "Accept", "*/*" },
                },

                Content = new StringContent(JsonConvert.SerializeObject(jsonValues), UnicodeEncoding.UTF8, "application/json")
           
            };


            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
          
            string body = await response.Content.ReadAsStringAsync();
            var res = JsonConvert.DeserializeObject<LoginAuth>(body);
            var parameters = new DynamicParameters();
            parameters.Add(Mapping.Mapping.user, username);
            parameters.Add(Mapping.Mapping.pass, password);
            parameters.Add(Mapping.Mapping.token, res.id);
            parameters.Add(Mapping.Mapping.ttl, res.ttl);
            parameters.Add(Mapping.Mapping.created, res.created);
            parameters.Add(Mapping.Mapping.userId, res.userId);
            if (response.StatusCode == HttpStatusCode.OK)
            {
               
                await DapperWrapper.ExecuteAsync(GetConnection(),
                       _loginauth, parameters, cancellationToken);
            }
            return res;
        }


      
    }
}
