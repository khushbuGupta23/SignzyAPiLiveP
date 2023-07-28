using Newtonsoft.Json;
using Signzy.ApiSandboxModification.Domain.Entities;
using Signzy.ApiSandboxModification.Infrastructure.Data.Dapper;
using Signzy.ApiSandboxModification.Infrastructure.Interfaces;
using System;
using System.Data;
using System.Net.Http.Headers;


namespace Signzy.ApiSandboxModification.Infrastructure.Repository
{
    public class EmailValidationRepository : DapperRepository, IEmailValidationRepository
    {
        private readonly DapperCommand _logintoken =
          new DapperCommand("dbo.spGetLoginToken", CommandType.StoredProcedure);
        public EmailValidationRepository(IDbConnectionFactory dbConnectionFactory, IDapperWrapper dapperWrapper) : base(dbConnectionFactory, dapperWrapper)
        {
        }

       

        public async Task<EmailValidation> EmailValidationAsync(string emailId, CancellationToken cancellationToken)
        {
           
            var res = await DapperWrapper.QueryAsync<TblAuth>(GetConnection(),
                      _logintoken, cancellationToken);
            string Token = res.First().token;
            string UserId = res.First().userId;

            Dictionary<string, string> jsonValues = new Dictionary<string, string>();
            jsonValues.Add("emailId", emailId);

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://preproduction.signzy.tech/api/v2/patrons/"+ UserId + "/emailvalidations"),
                Headers =
                            {
                                { "Accept-Language", "en-US,en;q=0.8" },
                                { "Accept", "*/*" },
                                { "Authorization", Token },
                            },
                Content = new StringContent("{\"essentials\":{\"emailId\":\""+ emailId + "\"}}")
                {
                        Headers =
                                {
                                    ContentType = new MediaTypeHeaderValue                      ("application/json")
                                }
                }
            };

            
            var response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();
            var body = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<EmailValidation>(body);
            
        }

            
    }
}
