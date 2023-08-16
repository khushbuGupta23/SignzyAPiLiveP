using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signzy.ApiSandboxModification.Domain.Entities
{
    public class UserModel
    {
        public string  FirstName { get; set; }
        public string  LastName { get; set; }
        public string  UserName { get; set; }
        public Guid  RoleId { get; set; }
        public string  Email { get; set; }
        public string  Password { get; set; }
        public int  CreatedBy { get; set; }
        public string  CreationDate { get; set; }
        public int  ModifiedBy { get; set; }
        public string ModifiedDate { get; set; }
        public bool IsActive { get; set; }
    }
}
