using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signzy.ApiSandboxModification.Domain.Entities.OrganizationModel
{
    public class UanNumber
    {
        public ResultUAN result { get; set; }
        public ErrorsUdhyag error { get; set; }

    }
    public class ResultUAN
    {
        public string uamNumber { get; set; }
        public string nameofEnterprise { get; set; }
        public string majorActivity { get; set; }
        public string socialCategory { get; set; }
        public string enterpriseType { get; set; }
        public string dateofCommencement { get; set; }
        public string dicName { get; set; }
        public string state { get; set; }
        public string appliedDate { get; set; }
        public string modifiedDate { get; set; }
        public string validTillDate { get; set; }
        public string nic2Digit { get; set; }
        public string nic4Digit { get; set; }
        public string nic5DigitCode { get; set; }
        public string status { get; set; }

    }

    public class EssentialsUAN
    {
        public string uamNumber { get; set; }
    }

    public class UANInput
    {
        public string type { get; set; }
        public EssentialsUAN essentials { get; set; }
    }
    public class ErrorsUdhyag
    {
        public string statusCode { get; set; }
        public string message { get; set; }
        public string status { get; set; }
        public string name { get; set; }


    }


}
