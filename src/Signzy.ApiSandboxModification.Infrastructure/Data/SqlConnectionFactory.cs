using Microsoft.Extensions.Configuration;
using Nippon.PaintPartner.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nippon.PaintPartner.Infrastructure.Data
{
    public class SqlConnectionFactory:IDbConnectionFactory
    {
        private readonly IConfiguration _configuration;

        public SqlConnectionFactory(IConfiguration configuration) 
        {
            _configuration = configuration;
        }
        public IDbConnection CreateConnection()
        {
            var connectionString = _configuration.GetConnectionString("MyDatabase");
            return new SqlConnection(connectionString);
        }

        public string GetPPWebPath()
        {
            var path = _configuration.GetSection("PPWebPath");
            return path.Value;
        }
    }
}
