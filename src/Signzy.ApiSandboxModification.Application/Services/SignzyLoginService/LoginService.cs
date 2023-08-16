using Signzy.ApiSandboxModification.Application.Interfaces;
using Signzy.ApiSandboxModification.Domain.Entities;
using Signzy.ApiSandboxModification.Infrastructure.Interfaces;
using System;

namespace Signzy.ApiSandboxModification.Application.Services.SignzyLoginService
{
    public class LoginService : ILoginService
    {

        private readonly ILoginRepository _loginRepository;

        public LoginService(ILoginRepository loginRepository)
        {
            _loginRepository = loginRepository;
        }
        
        public async Task<LoginAuth> LoginVerificationAsync(string username, string password, CancellationToken cancellationToken)
        {

            return await _loginRepository.LoginVerificationAsync(username, password, cancellationToken);

        }
    }
}
