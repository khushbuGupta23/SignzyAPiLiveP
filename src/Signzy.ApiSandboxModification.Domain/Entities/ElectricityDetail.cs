using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signzy.ApiSandboxModification.Domain.Entities
{
    public class ElectricityDetail
    {
        public EssentialsElectricity essentials { get; set; }
        public string id { get; set; }
        public string patronId { get; set; }
        public ResultElectricity result { get; set; }
    }
    public class EssentialsElectricity
    {
        public string consumerNo { get; set; }
        public string electricityProvider { get; set; }
        public string installationNumber { get; set; }
        public string mobileNo { get; set; }
    }

    public class ResultElectricity
    {
        public string name { get; set; }
        public string address { get; set; }
        public string amountPayable { get; set; }
        public string billAmount { get; set; }
        public string billDate { get; set; }
        public string billDueDate { get; set; }
        public string billIssueDate { get; set; }
        public string billNo { get; set; }
        public string consumerNo { get; set; }
        public string email { get; set; }
        public string mobileNumber { get; set; }
        public string TariffCode { get; set; }
        public string SectionName { get; set; }
        public string DueAmount { get; set; }
        public string accountId { get; set; }
        public string billingUnit { get; set; }
        public string consumptionUnits { get; set; }
        public string electricityProvider { get; set; }
        public SplitAddressElectricity splitAddress { get; set; }
    }

   

    public class SplitAddressElectricity
    {
        public List<object> district { get; set; }
        public List<List<object>> state { get; set; }
        public List<object> city { get; set; }
        public string pincode { get; set; }
        public List<string> country { get; set; }
        public string addressLine { get; set; }
    }


}
