using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signzy.ApiSandboxModification.Domain.Entities
{
   
        public class EmailValidation
        {
            public Essentials essentials { get; set; }
            public Result result { get; set; }
            public string id { get; set; }
            public string patronId { get; set; }
        }
        public class Result
        {
            public EmailverifyData emailverifyData { get; set; }

        }
        public class EmailverifyData
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
            public string mx_found { get; set; }
            public string mx_record { get; set; }
            public string firstname { get; set; }
            public string lastname { get; set; }
            public string gender { get; set; }
            public string country { get; set; }
            public string region { get; set; }
            public string city { get; set; }
            public string zipcode { get; set; }
            public string name { get; set; }
        
    }
}
