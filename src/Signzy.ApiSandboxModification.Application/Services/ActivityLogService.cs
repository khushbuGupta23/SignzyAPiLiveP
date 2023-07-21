using Nippon.PaintPartner.Application.Interfaces;
using Nippon.PaintPartner.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nippon.PaintPartner.Application.Services
{
    public class ActivityLogService : IActivityLogService
    {
        private readonly IActivityLogRepository _activityLogRepository;
        public ActivityLogService(IActivityLogRepository activityLogRepository)
        {
            _activityLogRepository = activityLogRepository;
        }

        public Task<int> AddUserActivityLogAsync(string module, string dashBoardModule, string page, string activity, int userId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
