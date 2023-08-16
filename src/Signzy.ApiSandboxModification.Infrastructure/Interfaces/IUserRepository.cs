using Signzy.ApiSandboxModification.Domain.Entities.JwtLogin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signzy.ApiSandboxModification.Infrastructure.Interfaces
{
    public interface IUserRepository
    {
        public Task<IEnumerable<jwtLoginModel>> GetLoginDetails(CancellationToken cancellationToken);
        public Task<string> AddUserAsync(string firstName, string lastname, string userName, Guid role, string email, string password, int createdBy, string creationDate, CancellationToken cancellationToken);
        public Task<string> LoginByUser(string userName, string password, CancellationToken cancellationToken);
        public Task<string> EncodePasswordToBase64(string password, CancellationToken cancellationToken);
    }
}
