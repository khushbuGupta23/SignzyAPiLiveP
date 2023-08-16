using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Signzy.ApiSandboxModification.Infrastructure.Repository
{
    public class EmailRepository
    {
        private readonly IHttpContextAccessor _httpcontextAccessor;
        private readonly DapperWapper _context;
        private string UserId;
        private readonly IConfiguration _configuration;
      
       
       
    }
}
