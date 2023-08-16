
using IdentityServer4.Models;
using Newtonsoft.Json;
using Signzy.ApiSandboxModification.Application.Interfaces;
using Signzy.ApiSandboxModification.Domain.Entities;
using Signzy.ApiSandboxModification.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Signzy.ApiSandboxModification.Application.Services
{
    public class OrganizationService : IOrganizationService
    {
        private readonly IOrganizationRepository _organizationRepository;

        public OrganizationService(IOrganizationRepository organizationRepository)
        {
            _organizationRepository = organizationRepository;
        }

    
        public async Task<UanNumber> SearchUanAsync(EssentialsUAN essentials1, CancellationToken cancellationToken)
        {
            var res= await _organizationRepository.SearchUanAsync(cancellationToken);
            string Token = res.First().token;
            string UserId = res.First().userId;
            UANInput UamNo = new UANInput
            {
                essentials = essentials1,
                type = "uam",

            };

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://preproduction.signzy.tech/api/v2/patrons/" + UserId + "/udyogaadhaars"),
                Headers =
                        {
                            { "Accept-Language", "en-US,en;q=0.8" },
                            { "Accept", "*/*" },
                             { "Authorization", Token },
                        },
                Content = new StringContent(JsonConvert.SerializeObject(UamNo), UnicodeEncoding.UTF8, "application/json")
            };
            var response = await client.SendAsync(request);

            var body = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<UanNumber>(body);
        }

        public async Task<UdyamRegiResponse> UdyamRegistrationAsync(string udyamNumber, CancellationToken cancellationToken)
        {
            var res= await _organizationRepository.UdyamRegistrationAsync( cancellationToken);

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
                Content = new StringContent("{\"essentials\":{\"udyamNumber\":\"" + udyamNumber + "\"}}")
                {
                    Headers =
                        {
                            ContentType = new MediaTypeHeaderValue("application/json")
                        }
                }
            };
            var response = await client.SendAsync(request);
            var body = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<UdyamRegiResponse>(body);
        }
    }
}
