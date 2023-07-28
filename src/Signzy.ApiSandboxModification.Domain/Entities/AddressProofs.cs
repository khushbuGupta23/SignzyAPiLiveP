using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signzy.ApiSandboxModification.Domain.Entities
{
    public class RequestOTP
    {
        public string task { get; set; }
        public Essential essentials { get; set; }
    }
    public class Essential
    {
        public string task { get; set; }
        public string countryCode { get; set; }
        public string mobileNumber { get; set; }
    }


    public class Res
    {
        public string referenceId { get; set; }
    }

    public class GenrateOtp
    {
        public Essential essentials { get; set; }
        public string id { get; set; }
        public string patronId { get; set; }
        public string task { get; set; }
        public Res result { get; set; }
    }

   
    public class Essentials1
    {
        public string task { get; set; }
        public string countryCode { get; set; }
        public string mobileNumber { get; set; }
        public string referenceId { get; set; }
        public string otp { get; set; }
    }



    public class ExtraFields
    {
    }

    public class Result2
    {
        public string name { get; set; }
        public string address { get; set; }
        public SplitAddress splitAddress { get; set; }
        public string dob { get; set; }
        public string mobileNumber { get; set; }
        public string countryCode { get; set; }
        public string email { get; set; }
        public string mobileNetworkOperator { get; set; }
        public string billingType { get; set; }
        public string alternatePhone { get; set; }
        public ExtraFields extraFields { get; set; }
    }

    public class SubmitOTP
    {
        public Essentials1 essentials { get; set; }
        public string id { get; set; }
        public string patronId { get; set; }
        public string task { get; set; }
        public Result2 result { get; set; }
    }

    public class SplitAddress
    {
        public List<string> district { get; set; }
        public List<List<string>> state { get; set; }
        public List<string> city { get; set; }
        public string pincode { get; set; }
        public List<string> country { get; set; }
        public string addressLine { get; set; }
    }
    public class GenrateOtpDb
    {

        public string UserId { get; set; }
        public string token { get; set; }
        public string task { get; set; }
        public string countryCode { get; set; }
        public string mobileNumber { get; set; }
        public string referenceId { get; set; }


    }

}
