using Signzy.ApiSandboxModification.Domain.Entities.OrganizationModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signzy.ApiSandboxModification.Application.Interfaces
{
    public interface IOrganizationService
    {
        public Task<UanNumber> SearchUanAsync(EssentialsUAN essentials1, CancellationToken cancellationToken);
        public Task<UdyamRegiResponse> UdyamRegistrationAsync(string udyamNumber, CancellationToken cancellationToken);
        public Task<ShopAndEstablishmentModel> ShopAndEstablishmentasync(string registrationNumber, string state, CancellationToken cancellationToken);
        public Task<IEnumerable<StateMasterModel>> GetAllStateListAsync(CancellationToken cancellationToken);
        public Task<EmpNameSerachV2Model> EmpNameSearchV2Async(EssentialsENSV essential, CancellationToken cancellationToken);
        public Task<ICAIModel> ICAIAsync(EssentialsICAI essential, CancellationToken cancellationToken);
    }
}
