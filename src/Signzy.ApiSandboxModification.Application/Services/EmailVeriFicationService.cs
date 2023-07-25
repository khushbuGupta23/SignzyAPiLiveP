
using Signzy.ApiSandboxModification.Application.Interfaces;
using Signzy.ApiSandboxModification.Domain.Entities;
using Signzy.ApiSandboxModification.Infrastructure.Interfaces;
using Signzy.ApiSandboxModification.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signzy.ApiSandboxModification.Application.Services
{
    public class EmailVeriFicationService : IEmailVerificationService
    {
        private readonly IEmailVerificationRepository _emailRepository;

        public EmailVeriFicationService(IEmailVerificationRepository emailRepository)
        {
            _emailRepository = emailRepository;
        }
        public async Task<Obj2> EmailVerificationAsync(string emailId, CancellationToken cancellationToken)
        {
            return await _emailRepository.EmailVerificationAsync(emailId, cancellationToken);
        }
       

    }
}
