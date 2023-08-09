using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signzy.ApiSandboxModification.Domain.Entities
{
    public class GstAuthToken
    {
        public EssentialsAuth essentials { get; set; }
        public string id { get; set; }
        public string patronId { get; set; }
        public string task { get; set; }
        public ResultAuth result { get; set; }
        public ErrorAuth error { get; set; }
    }
    public class ResultAuth
    {
        public string message { get; set; }
        public string authToken { get; set; }
        public int expiry { get; set; }
        public string sek { get; set; }
    }



    public class EssentialsAuth
    {
        public string gstin { get; set; }
        public string username { get; set; }
        public string otp { get; set; }
        public string appKey { get; set; }
    }

    public class GstAuthInput
    {
        public string task { get; set; }
        public EssentialsAuth essentials { get; set; }
    }
    public class ErrorAuth
    {
        public string statusCode { get; set; }
        public string message { get; set; }
        public string status { get; set; }
        public string name { get; set; }
    }
}
