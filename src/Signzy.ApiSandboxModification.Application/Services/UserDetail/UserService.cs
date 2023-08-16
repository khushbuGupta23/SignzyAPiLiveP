
using Signzy.ApiSandboxModification.Application.Interfaces;
using Signzy.ApiSandboxModification.Domain.Entities.JwtLogin;
using Signzy.ApiSandboxModification.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signzy.ApiSandboxModification.Application.Services.UserDetail
{
    public class UserService : IUserService
    {

        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<IEnumerable<jwtLoginModel>> GetLoginDetails(CancellationToken cancellationToken)
        {
            return await _userRepository.GetLoginDetails(cancellationToken);
        }

        public async Task<string> LoginByUser(string userName, string password, CancellationToken cancellationToken)
        {
            return await _userRepository.LoginByUser(userName, password, cancellationToken);
        }

        public async Task<string> AddUserAsync(string firstName, string lastname, string userName, Guid role, string email, string password, int createdBy, string creationDate, CancellationToken cancellationToken)
        {
            try
            {
                var res= await _userRepository.EncodePasswordToBase64(password, cancellationToken);
                if (creationDate == null)
                {
                    var date_str = DateTime.Now;
                    creationDate = date_str.ToString();
                    password = res;
                }
                return await _userRepository.AddUserAsync(firstName, lastname, userName, role, email, password, createdBy, creationDate, cancellationToken);
            }
            catch (Exception ex)
            {
               return null;
            }
        }

    }
}
