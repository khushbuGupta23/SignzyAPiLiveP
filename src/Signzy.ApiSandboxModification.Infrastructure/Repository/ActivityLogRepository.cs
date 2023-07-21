using Dapper;
using Nippon.PaintPartner.Infrastructure.Data.Dapper;
using Nippon.PaintPartner.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nippon.PaintPartner.Infrastructure.Repository
{
    public class ActivityLogRepository : DapperRepository, IActivityLogRepository
    {
        private readonly DapperCommand _addLog =
           new DapperCommand("dbo.npnSp_Admin_insUserActivityLogs", CommandType.StoredProcedure);

        public ActivityLogRepository(IDbConnectionFactory dbConnectionFactory, IDapperWrapper dapperWrapper) :
            base(dbConnectionFactory, dapperWrapper)
        {
        }

        public async Task<int> AddUserActivityLogAsync(string module, string dashBoardModule, string page, string activity, int userId, CancellationToken cancellationToken)
        {
            var parameters = new DynamicParameters();
            parameters.Add(Mapping.Mapping.ModuleName, module);
            parameters.Add(Mapping.Mapping.DashBoardModuleName, dashBoardModule);
            parameters.Add(Mapping.Mapping.PageName, page);
            parameters.Add(Mapping.Mapping.AcivityName, activity);
            parameters.Add(Mapping.Mapping.UserId, userId);

            var result = await DapperWrapper.ExecuteAsync(GetConnection(),
                   _addLog, parameters, cancellationToken);

            return result;
        }
    }
}
