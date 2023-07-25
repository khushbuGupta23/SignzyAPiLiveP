using Signzy.ApiSandboxModification.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signzy.ApiSandboxModification.Application.Interfaces
{
    public interface IEmailVerificationService
    {
        public Task<Obj2> EmailVerificationAsync(string emailId, CancellationToken cancellationToken);
    }
}
