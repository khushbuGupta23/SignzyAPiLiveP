using IdentityServer4.Models;
using Newtonsoft.Json;
using Signzy.ApiSandboxModification.Domain.Entities;
using Signzy.ApiSandboxModification.Infrastructure.Data.Dapper;
using Signzy.ApiSandboxModification.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Signzy.ApiSandboxModification.Infrastructure.Repository
{
    public class OrganizationRepository :DapperRepository, IOrganizationRepository
    {
        private readonly DapperCommand _logintoken =
         new DapperCommand("dbo.spGetLoginToken", CommandType.StoredProcedure);

        public OrganizationRepository(IDbConnectionFactory dbConnectionFactory, IDapperWrapper dapperWrapper) :
          base(dbConnectionFactory, dapperWrapper)
        {
        }


        public async Task<IEnumerable<TblAuth>> SearchUanAsync(CancellationToken cancellationToken)
        {
            var res = await DapperWrapper.QueryAsync<TblAuth>(GetConnection(),
                            _logintoken, cancellationToken);
            return res;
            
        }

        public async Task<IEnumerable<TblAuth>> UdyamRegistrationAsync( CancellationToken cancellationToken)
        {
            return await DapperWrapper.QueryAsync<TblAuth>(GetConnection(), _logintoken,      cancellationToken);
                    
        }
    }
}
