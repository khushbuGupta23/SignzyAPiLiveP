using Signzy.ApiSandboxModification.Domain.Entities.JwtLogin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signzy.ApiSandboxModification.Application.Interfaces
{
    public interface IUserService
    {
        public Task<IEnumerable<jwtLoginModel>> GetLoginDetails(CancellationToken cancellationToken);
        public Task<string> LoginByUser(string userName, string password, CancellationToken cancellationToken);
        public Task<string> AddUserAsync(string firstName, string lastname, string userName, Guid role, string email, string password, int createdBy, string creationDate, CancellationToken cancellationToken);
    }
}
