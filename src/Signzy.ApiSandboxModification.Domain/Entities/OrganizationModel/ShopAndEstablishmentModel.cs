using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signzy.ApiSandboxModification.Domain.Entities.OrganizationModel
{
    public class ShopAndEstablishmentModel
    {
        public EssentialSAE essentials { get; set; }
        public string id { get; set; }
        public string patronId { get; set; }
        public ResultSAE result { get; set; }
        public ErrorsSAE error { get; set; }
    }
    public class EssentialSAE
    {
        public string registrationNumber { get; set; }
        public string state { get; set; }
    }

    public class ResultSAE
    {
        public RegistrationDetails registrationDetails { get; set; }
        public string dateOfCommencement { get; set; }
        public string address { get; set; }
        public SplitAddress splitAddress { get; set; }
        public string district { get; set; }
        public string name { get; set; }
        public string pincode { get; set; }
        public string dateOfCommencment { get; set; }
        public Summary summary { get; set; }
        public Detailed detailed { get; set; }
    }
    public class Detailed
    {
        public RegistrationDetails registrationDetails { get; set; }
        public string dateOfCommencement { get; set; }
        public string address { get; set; }
        public SplitAddress splitAddress { get; set; }
        public string district { get; set; }
        public string name { get; set; }
        public string pincode { get; set; }
    }
    public class RegistrationDetails
    {
        public string registrationNo { get; set; }
        public string date { get; set; }
        public string validUpto { get; set; }
    }

    public class Summary
    {
        public string registrationNumber { get; set; }
        public string name { get; set; }
        public string status { get; set; }
        public string dateOfCommencement { get; set; }
        public string address { get; set; }
        public SplitAddressSAE splitAddress { get; set; }
    }
    public class SplitAddressSAE
    {
        public List<string> district { get; set; }
        public List<List<string>> state { get; set; }
        public List<string> city { get; set; }
        public string pincode { get; set; }
        public List<string> country { get; set; }
        public string addressLine { get; set; }
    }
    public class ErrorsSAE
    {
        public int statusCode { get; set; }
        public string name { get; set; }
        public string message { get; set; }
        public int status { get; set; }
    }


}
