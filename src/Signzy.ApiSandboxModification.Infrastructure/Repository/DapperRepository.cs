using Dapper;
using Signzy.ApiSandboxModification.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signzy.ApiSandboxModification.Infrastructure.Repository
{
    public abstract class DapperRepository
    {
        protected readonly IDapperWrapper DapperWrapper;

        protected DapperRepository(IDbConnectionFactory factory, IDapperWrapper dapperWrapper)
        {
            Factory = factory;
            DapperWrapper = dapperWrapper;
        }

        private static IDbConnectionFactory Factory { get; set; }

        protected static IDbConnection GetConnection()
        {
            return Factory.CreateConnection();
        }

        public string GetPPWebPath()
        {
            return Factory.GetPPWebPath();
        }
    }
}
