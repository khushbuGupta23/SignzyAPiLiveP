
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signzy.ApiSandboxModification.Domain.Interfaces
{
    public interface INotificationUtilityService
    {
        public Task<string> SendNotification(int UserId,int RegionId,int RowCount, string Title, string message, string FolderName, string ImageName, string ImageExt, string Status, CancellationToken cancellationToken);
    }
}
