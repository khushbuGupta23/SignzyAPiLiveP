using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signzy.ApiSandboxModification.Domain.Entities
{
    public class GstrInitiations
    {
        public EssentialsGSTR essentials { get; set; }
        public string id { get; set; }
        public string patronId { get; set; }
        public string task { get; set; }
        public ResultGSTR result { get; set; }
        public bool IsSuccess { get; set; }
        public Errors Error { get; set; }
    }
        public class EssentialsGSTR
        {
            public string gstin { get; set; }
            public string username { get; set; }
        }

        public class ResultGSTR
        {
            public string message { get; set; }
            public string appKey { get; set; }
        }
    public class GstrInput
    {
        public string task { get; set; }
        public EssentialsGSTR essentials { get; set; }
    }
    public class Errors {
        public string statusCode { get; set; }
        public string message { get; set; }
        public string status { get; set; }
    }
}
