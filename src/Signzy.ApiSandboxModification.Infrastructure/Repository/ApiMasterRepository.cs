using Signzy.ApiSandboxModification.Domain.Entities;
using Signzy.ApiSandboxModification.Infrastructure.Data.Dapper;
using Signzy.ApiSandboxModification.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;

namespace Signzy.ApiSandboxModification.Infrastructure.Repository
{
    public class ApiMasterRepository: DapperRepository, IApiMasterRepository
    {
        private readonly DapperCommand _apilist =
          new DapperCommand("dbo.sp_GetApiList", CommandType.StoredProcedure);

        public ApiMasterRepository(IDbConnectionFactory dbConnectionFactory, IDapperWrapper dapperWrapper) :
         base(dbConnectionFactory, dapperWrapper)
        {
        }
        public async Task<IEnumerable<apiMasterModel>>GetAllAPIListAsync(CancellationToken cancellationToken)
        {
            var res= await DapperWrapper.QueryAsync<apiMasterModel>(GetConnection(),
                _apilist,cancellationToken);
            return res;
        }

    }
}
