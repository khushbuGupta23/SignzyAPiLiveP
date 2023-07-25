using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signzy.ApiSandboxModification.Domain.Entities
{
    public class TblAuth
    {
        public int Id { get; set; }
        public string token { get; set; }
        public string Title { get; set; }
        public string CreatedOn { get; set; }
        public string userId { get; set; }
        public bool IsExpire { get; set; }

    }
}
