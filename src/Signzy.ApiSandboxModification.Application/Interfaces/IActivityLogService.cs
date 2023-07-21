using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nippon.PaintPartner.Application.Interfaces
{
    public interface IActivityLogService
    {
        public Task<int> AddUserActivityLogAsync(string module, string dashBoardModule, string page, string activity, int userId, CancellationToken cancellationToken);
    }
}
