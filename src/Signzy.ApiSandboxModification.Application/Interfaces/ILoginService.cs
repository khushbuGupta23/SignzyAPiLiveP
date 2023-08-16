using Signzy.ApiSandboxModification.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signzy.ApiSandboxModification.Application.Interfaces
{
    public interface ILoginService
    {
        public Task<LoginAuth> LoginVerificationAsync(string username, string password, CancellationToken cancellationToken);
    }
}
