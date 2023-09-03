using Dapper;
using Signzy.ApiSandboxModification.Domain.Entities.JwtLogin;
using Signzy.ApiSandboxModification.Infrastructure.Data.Dapper;
using Signzy.ApiSandboxModification.Infrastructure.Interfaces;
using System.Data;

namespace Signzy.ApiSandboxModification.Infrastructure.Repository
{
    public class UserRepository : DapperRepository, IUserRepository
    {
        private readonly DapperCommand _getUserDetail =
            new DapperCommand("dbo.sp_getUserDetail", CommandType.StoredProcedure);
        private readonly DapperCommand _loginUser =
            new DapperCommand("dbo.sp_LoginByUser", CommandType.StoredProcedure);
        private readonly DapperCommand _userauth =
           new DapperCommand("dbo.spUserLogin", CommandType.StoredProcedure);

        public UserRepository(IDbConnectionFactory dbConnectionFactory, IDapperWrapper dapperWrapper) :
          base(dbConnectionFactory, dapperWrapper)
        {
        }
        public async Task<IEnumerable<jwtLoginModel>> GetLoginDetails(CancellationToken cancellationToken)
        {
            return await DapperWrapper.QueryAsync<jwtLoginModel>(GetConnection(),
                _getUserDetail, cancellationToken);
            
        }

        public async Task <string>AddUserAsync(string firstName,string lastname,string userName,Guid role,string email,string password,int createdBy,string creationDate,CancellationToken cancellationToken)
        {
            try {
                var parameters = new DynamicParameters();
            parameters.Add(Mapping.Mapping.FirstName, firstName);
            parameters.Add(Mapping.Mapping.LastName, lastname);
            parameters.Add(Mapping.Mapping.UserName, userName);
            parameters.Add(Mapping.Mapping.Role, role);
            parameters.Add(Mapping.Mapping.Email, email);
            parameters.Add(Mapping.Mapping.pass, password);
            parameters.Add(Mapping.Mapping.CreatedBy, createdBy);
            parameters.Add(Mapping.Mapping.CreationDate, creationDate);
          
              var result=  await DapperWrapper.ExecuteAsync(GetConnection(),
                       _userauth, parameters, cancellationToken);
            if (result!=null)
                
                return "User Added Successfully";
                else
                {
                    return "error";
                }
        }
            catch (Exception ex)
            {
                return "Failure";
            }

          
        }

        public async Task<string> LoginByUser(string userName, string password, CancellationToken cancellationToken)
        {

            var parameters = new DynamicParameters();
            parameters.Add(Mapping.Mapping.UserName, userName);
            parameters.Add(Mapping.Mapping.Password, password);
            var result = await DapperWrapper.ExecuteAsync(GetConnection(),
                   _loginUser, parameters, cancellationToken);
            if (result != null)

                return "Login Successfully";
            else
            {
                return "error";
            }
        }
        public async Task<string> EncodePasswordToBase64(string password,CancellationToken cancellationToken)
        {
            try
            {
                byte[] encData_byte = new byte[password.Length];
                encData_byte = System.Text.Encoding.UTF8.GetBytes(password);
                string encodedData = Convert.ToBase64String(encData_byte);
                return encodedData;
            }
            catch (Exception ex)
            {
                throw new Exception("Error in base64Encode" + ex.Message);
            }
        }

        public string DecodeFrom64(string encodedData)
        {
            System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();
            System.Text.Decoder utf8Decode = encoder.GetDecoder();
            byte[] todecode_byte = Convert.FromBase64String(encodedData);
            int charCount = utf8Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length);
            char[] decoded_char = new char[charCount];
            utf8Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0);
            string result = new String(decoded_char);
            return result;
        }
    }
}
