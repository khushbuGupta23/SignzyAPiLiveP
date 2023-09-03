using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signzy.ApiSandboxModification.Domain.Entities.OrganizationModel
{
    public class ICAIModel
    {
        public EssentialsICAI essentials { get; set; }
        public string id { get; set; }
        public string patronId { get; set; }
        public ResultICAI result { get; set; }
        public ErrorsICAI error { get; set; }
    }
    public class EssentialsICAI
    {
        public string memberNumber { get; set; }
    }
    public class ResultICAI
    {
        public string status { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public SplitAddressICAI splitAddress { get; set; }
    }
    public class SplitAddressICAI
    {
        public List<List<object>> state { get; set; }
        public List<object> district { get; set; }
        public List<object> city { get; set; }
        public string pincode { get; set; }
        public List<string> country { get; set; }
        public string addressLine { get; set; }
    }
    public class ErrorsICAI
    {
        public int statusCode { get; set; }
        public string name { get; set; }
        public string message { get; set; }
        public int status { get; set; }
    }
    public class ICAIInput
    {
        public EssentialsICAI essentials { get; set; }
    }
}
