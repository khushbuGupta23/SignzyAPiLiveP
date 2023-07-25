using Microsoft.AspNetCore.Mvc;
using Signzy.ApiSandboxModification.Application.Interfaces;
using Signzy.ApiSandboxModification.Domain.Entities;

namespace Signzy.ApiSandboxModification.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginService _loginService;

        public LoginController(ILoginService loginService)
        {
            _loginService = loginService;
        }
        [HttpPost]
        [Route("LoginVerificationAsync")]
        public async Task<LoginAuth> LoginVerificationAsync(string username, string password, CancellationToken cancellationToken)
        {
            return await _loginService.LoginVerificationAsync(username,password, cancellationToken);
        }
    }
}
