using ExcelDataReader.Log;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Org.BouncyCastle.Pqc.Crypto.Crystals.Dilithium;
using Signzy.ApiSandboxModification.Application.Interfaces;
using Signzy.ApiSandboxModification.Application.Services.JwtToken.Model;
using Signzy.ApiSandboxModification.Application.Services.UserDetail;
using Signzy.ApiSandboxModification.Domain.Entities;
using Signzy.ApiSandboxModification.Domain.Entities.JwtLogin;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Signzy.ApiSandboxModification.API.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        private IConfiguration _configuration;
        public AuthController(IConfiguration configuration)
        {
            _configuration = configuration;
        }


        [AllowAnonymous]
        [HttpPost("JwtLogin")]
        public IActionResult Auth([FromBody] User user)
        {
            IActionResult response = Unauthorized();
            //var user = Authenticate(login);
            if (user != null)
            {
                if(user.UserName.Equals("admin")&& user.Password.Equals("MTIz")) 
                {
                    var issuer = _configuration["Jwt:Issuer"];
                    var audience = _configuration["Jwt:Audience"];
                    var key = Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]);
                        var signingCredentials = new SigningCredentials(
                                            new SymmetricSecurityKey(key),
                                            SecurityAlgorithms.HmacSha512Signature
                                        );
                    var subject = new ClaimsIdentity(new[]
                        {
                        new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
                        new Claim(JwtRegisteredClaimNames.Email, user.UserName),
                        });

                    var expires = DateTime.UtcNow.AddMinutes(10);
                    var tokenDescriptor = new SecurityTokenDescriptor
                    {
                        Subject = subject,
                        Expires = DateTime.UtcNow.AddMinutes(10),
                        Issuer = issuer,
                        Audience = audience,
                        SigningCredentials = signingCredentials
                    };
                    var tokenHandler = new JwtSecurityTokenHandler();
                    var token = tokenHandler.CreateToken(tokenDescriptor);
                    var jwtToken = tokenHandler.WriteToken(token);
                    return Ok(new JWTTokenResponse
                    {
                        Token = jwtToken

                    });

                }
            }
            return response;
        }

        private UserModel Authenticate(User login)
        {
            jwtLoginModel user = new jwtLoginModel();
            //List<jwtLoginModel> loginDetails = _Login.GetLoginDetails(login.Username).Result;


            return null;
        }

    }
}
