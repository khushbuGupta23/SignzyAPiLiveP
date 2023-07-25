using Microsoft.AspNetCore.Mvc;
using Signzy.ApiSandboxModification.Application.Interfaces;
using Signzy.ApiSandboxModification.Domain.Entities;

namespace Signzy.ApiSandboxModification.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailVerificationController : ControllerBase
    {
        private readonly IEmailVerificationService _emailService;

        public EmailVerificationController(IEmailVerificationService emailService)
        {
            _emailService = emailService;
        }
      

        [HttpPost]
        [Route("EmailVerificationAsync")]
        public async Task<Obj2> EmailVerificationAsync(string emailId,CancellationToken cancellationToken)
        {
            return await _emailService.EmailVerificationAsync(emailId,cancellationToken);
        }
    }
}
