
using Azure;
using IdentityServer4.Models;
using Newtonsoft.Json;
using Signzy.ApiSandboxModification.Application.Interfaces;
using Signzy.ApiSandboxModification.Domain.Entities;
using Signzy.ApiSandboxModification.Domain.Entities.OrganizationModel;
using Signzy.ApiSandboxModification.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
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
            var res = await _organizationRepository.SearchUanAsync(cancellationToken);
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
            var res = await _organizationRepository.UdyamRegistrationAsync(cancellationToken);

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

        public async Task<ShopAndEstablishmentModel> ShopAndEstablishmentasync(string registrationNumber, string state, CancellationToken cancellationToken)
        {
            var res = await _organizationRepository.GetTokenUserIdAsync(cancellationToken);
            string Token = res.First().token;
            string UserId = res.First().userId;
            Dictionary<string, string> jsonValues = new Dictionary<string, string>();
            jsonValues.Add("registrationNumber", registrationNumber);
            jsonValues.Add("state", state);
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://preproduction.signzy.tech/api/v2/patrons/" + UserId + "/snecs"),
                Headers =
                        {
                            { "Accept-Language", "en-US,en;q=0.8" },
                            { "Accept", "*/*" },
                            { "Authorization", Token},
                        },
                Content = new StringContent("{\"essentials\":{\"registrationNumber\":\"" + registrationNumber + "\",\"state\":\"" + state + "\"}}")
                {
                    Headers =
                        {
                            ContentType = new MediaTypeHeaderValue("application/json")
                        }
                }
            };
            var response = await client.SendAsync(request);

            var body = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ShopAndEstablishmentModel>(body);
        }


        public async Task<IEnumerable<StateMasterModel>> GetAllStateListAsync(CancellationToken cancellationToken)
        {
            return await _organizationRepository.GetAllStateListAsync(cancellationToken);
        }

    
        public async Task<EmpNameSerachV2Model>EmpNameSearchV2Async(EssentialsENSV essential,CancellationToken cancellationToken)
            {
            var res = await _organizationRepository.UdyamRegistrationAsync(cancellationToken);
            string Token = res.First().token;
            string UserId = res.First().userId;
            
            ENSVInput eNSV = new ENSVInput
            {
                essentials = essential,
                task = "employeeNameSearchv2",
        };
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://preproduction.signzy.tech/api/v2/patrons/" + UserId + "/epfos"),
                Headers =
                        {
                            { "Accept-Language", "en-US,en;q=0.8" },
                            { "Accept", "*/*" },
                            { "Authorization", Token },
                        },
                Content = new StringContent(JsonConvert.SerializeObject(eNSV), UnicodeEncoding.UTF8, "application/json")
            };
            var response = await client.SendAsync(request);
            var body = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<EmpNameSerachV2Model>(body);

        }

        public async Task<ICAIModel> ICAIAsync(EssentialsICAI essential,CancellationToken cancellationToken)
        {
            var res = await _organizationRepository.GetTokenUserIdAsync(cancellationToken);
            string Token = res.First().token;
            string UserId = res.First().userId;

            ICAIInput icai = new ICAIInput
            {
                essentials = essential,
            };
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://preproduction.signzy.tech/api/v2/patrons/" + UserId + "/icais"),
                Headers =
                        {
                            { "Accept-Language", "en-US,en;q=0.8" },
                            { "Accept", "*/*" },
                            { "Authorization", Token },
                        },
                Content = new StringContent(JsonConvert.SerializeObject(icai), UnicodeEncoding.UTF8, "application/json")
            };
            var response = await client.SendAsync(request);
            var body = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ICAIModel>(body);
        }
    }
}
