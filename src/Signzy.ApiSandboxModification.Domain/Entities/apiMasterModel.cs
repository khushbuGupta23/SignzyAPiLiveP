using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signzy.ApiSandboxModification.Domain.Entities
{
    public class apiMasterModel
    {
        public Guid Id { get; set; }
        public string ApiName { get; set; }
        public int CreatedBy { get; set; }
        public string CreationDate { get; set;}
        public int ModifiedBy { get; set; }
        public string ModifiedDate { get; set; }
        public bool IsActive { get; set; }

    }
}
