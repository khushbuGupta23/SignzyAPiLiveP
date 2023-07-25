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
    public class EmailValidationService: IEmailValidationService
    {

        private readonly IEmailValidationRepository _emailRepository;
        public EmailValidationService(IEmailValidationRepository emailRepository)
        {
            _emailRepository = emailRepository;
        }
        public async Task<EmailValidation> EmailValidationAsync(string emailId, CancellationToken cancellationToken)
        {
            return await _emailRepository.EmailValidationAsync(emailId, cancellationToken);
        }

    }
}
