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
        public async Task<Results> EmailValidationAsync(string emailId, CancellationToken cancellationToken)
        {
            var data = await _emailRepository.EmailValidationAsync(emailId, cancellationToken);

            return new Results
            {
                email = data?.result?.emailverifyData?.email,
                status = data?.result?.emailverifyData?.status,
                sub_status = data?.result?.emailverifyData?.sub_status,
                free_email = data?.result?.emailverifyData?.free_email,
                account = data?.result?.emailverifyData?.account,
                city = data?.result?.emailverifyData?.city,
                country = data?.result?.emailverifyData?.country,
                did_you_mean = data?.result?.emailverifyData?.did_you_mean,
                domain = data?.result?.emailverifyData?.domain,
                smtp_provider = data?.result?.emailverifyData?.smtp_provider,
                gender = data?.result?.emailverifyData?.gender,
                region = data?.result?.emailverifyData?.region,
                name = data?.result?.emailverifyData?.name,
            };
        }

    }
}
