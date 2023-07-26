using Microsoft.AspNetCore.Mvc;
using Signzy.ApiSandboxModification.Application.Interfaces;
using Signzy.ApiSandboxModification.Domain.Entities;

namespace Signzy.ApiSandboxModification.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailValidationController : ControllerBase
    {

        private readonly IEmailValidationService _emailService;

        public EmailValidationController(IEmailValidationService emailService)
        {
            _emailService = emailService;
        }


        [HttpPost]
        [Route("EmailValidationAsync")]
        public async Task<EmailValidation> EmailValidationAsync(string emailId, CancellationToken cancellationToken)
        {
            return await _emailService.EmailValidationAsync(emailId, cancellationToken);
        }
    }
}
