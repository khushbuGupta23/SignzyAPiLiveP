using Newtonsoft.Json;
using Signzy.ApiSandboxModification.Domain.Entities;
using Signzy.ApiSandboxModification.Infrastructure.Data.Dapper;
using Signzy.ApiSandboxModification.Infrastructure.Interfaces;
using System;
using System.Collections.Concurrent;
using System.Data;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;


namespace Signzy.ApiSandboxModification.Infrastructure.Repository
{
    public class EmailValidationRepository : DapperRepository, IEmailValidationRepository
    {
        private readonly DapperCommand _logintoken =
          new DapperCommand("dbo.spGetLoginToken", CommandType.StoredProcedure);
        public EmailValidationRepository(IDbConnectionFactory dbConnectionFactory, IDapperWrapper dapperWrapper) :
           base(dbConnectionFactory, dapperWrapper)
        {
        }

       

        public async Task<EmailValidation> EmailValidationAsync(string emailId, CancellationToken cancellationToken)
        {
            Dictionary<string, string> jsonValues = new Dictionary<string, string>();
            jsonValues.Add("emailId", emailId);

            //var res = await DapperWrapper.QueryAsync<TblAuth>(GetConnection(),
            //          _logintoken, cancellationToken);
            //string Token = res.First().token;

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://preproduction.signzy.tech/api/v2/patrons/6492ba6a2d80a00024d79f9c/emailvalidations"),
                Headers =
                         {
                              { "Accept-Language", "en-US,en;q=0.8" },
                              { "Accept", "*/*" },
                              { "Authorization", "NF9TrmGFZ0KP3FuKO1w1xLoj3A8U87GhRt4rpowS0nGxo1iY4FEEAROAVh7C7KI6"},
                          },

            
                Content = new StringContent(JsonConvert.SerializeObject(jsonValues), UnicodeEncoding.UTF8, "application/json")

            };
            var response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();
            var body = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<EmailValidation>(body);
            
        }
            
    }
}
