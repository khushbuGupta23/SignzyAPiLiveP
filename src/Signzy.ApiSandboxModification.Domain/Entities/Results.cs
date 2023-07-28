using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signzy.ApiSandboxModification.Domain.Entities
{
    public class Results
    {
        public string email { get; set; }
        public string status { get; set; }
        public string sub_status { get; set; }
        public string free_email { get; set; }
        public string did_you_mean { get; set; }
        public string account { get; set; }
        public string domain { get; set; }
        public string domain_age_days { get; set; }
        public string smtp_provider { get; set; }
        public string gender { get; set; }
        public string country { get; set; }
        public string region { get; set; }
        public string city { get; set; }
        public string name { get; set; }

    }
}
