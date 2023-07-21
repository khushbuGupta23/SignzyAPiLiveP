using Dapper;
using Nippon.PaintPartner.Infrastructure.Data.Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nippon.PaintPartner.Infrastructure.Interfaces
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
