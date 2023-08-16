using Dapper;
using Signzy.ApiSandboxModification.Domain.Entities.JwtLogin;
using Signzy.ApiSandboxModification.Infrastructure.Data.Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signzy.ApiSandboxModification.Infrastructure.Interfaces
{
    public interface IDapperWrapper
    {
        public Task<IEnumerable<T>> QueryAsync<T>(
            IDbConnection dbConnection,
            DapperCommand dapperCommand,
            DynamicParameters parameters,
            CancellationToken cancellationToken = default);

        public Task<IEnumerable<T>> QueryAsync<T>(
            IDbConnection dbConnection,
            DapperCommand dapperCommand,
            CancellationToken cancellationToken = default);

        public Task<T> QuerySingleAsync<T>(
            IDbConnection dbConnection,
            DapperCommand dapperCommand,
            DynamicParameters parameters,
            CancellationToken cancellationToken = default);

        public Task<T> QueryFirstOrDefaultAsync<T>(
            IDbConnection dbConnection,
            DapperCommand dapperCommand,
            DynamicParameters parameters,
            CancellationToken cancellationToken = default);

        public Task<int> ExecuteAsync(IDbConnection dbConnection, DapperCommand dapperCommand, DynamicParameters
            parameters, CancellationToken cancellationToken = default);

    }
}
