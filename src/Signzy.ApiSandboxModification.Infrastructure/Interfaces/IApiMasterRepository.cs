using Signzy.ApiSandboxModification.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signzy.ApiSandboxModification.Infrastructure.Interfaces
{
    public interface IApiMasterRepository
    {
        public Task<IEnumerable<apiMasterModel>> GetAllAPIListAsync(CancellationToken cancellationToken);
    }
}
