using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Signzy.ApiSandboxModification.Application.EmailService;
using Signzy.ApiSandboxModification.Application.Interfaces;
using Signzy.ApiSandboxModification.Domain.Entities.JwtLogin;

namespace Signzy.ApiSandboxModification.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
       
        public UserController(IUserService UserService)
        {
            _userService = UserService;
        }
        [HttpPost]
        [Route ("LoginByUser")]
        public async Task<string> LoginByUser(string userName, string password, CancellationToken cancellationToken)
        {
            return await _userService.LoginByUser (userName, password, cancellationToken);
        }

        [HttpPost]
        [Route("AddUserAsync")]
        public async Task<string> AddUserAsync(string firstName, string lastname, string userName, Guid role, string email, string password, int createdBy, string? creationDate, CancellationToken cancellationToken)
        {
            return await _userService.AddUserAsync(firstName,lastname,userName,role,email,password,createdBy,creationDate,cancellationToken);
        }


        [HttpGet]
        [Route("GetLoginDetails")]
        public async Task<IEnumerable<jwtLoginModel>> GetLoginDetails(CancellationToken cancellationToken)
        {
            return await _userService.GetLoginDetails(cancellationToken);
        }
        //[HttpPost("send-email")]
        //public async Task<IActionResult> SendEmailAsync([FromBody] EmailModel model)
        //{
        //    // Validate model, process data, etc.

        //    await _emailService.SendEmailAsync(model.ToEmail, model.Subject, model.Content);

        //    return Ok("Email sent successfully.");
        //}
    }
}
