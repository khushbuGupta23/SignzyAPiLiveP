using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signzy.ApiSandboxModification.Domain.Entities
{
        public class UdyamRegiResponse
        {
            public EssentialsUdyam essentials { get; set; }
            public string id { get; set; }
            public string patronId { get; set; }
            public ResultUdyam result { get; set; }
         }
        public class EnterpriseType
        {
            public string dataYear { get; set; }
            public string classificationYear { get; set; }
            public string enterpriseType { get; set; }
            public string classificationDate { get; set; }
        }

        public class EssentialsUdyam
        {
            public string udyamNumber { get; set; }
        }

        public class GeneralInfo
        {
            public string udyamRegistrationNumber { get; set; }
            public string nameOfEnterprise { get; set; }
            public string majorActivity { get; set; }
            public string organisationType { get; set; }
            public string socialCategory { get; set; }
            public string dateOfIncorporation { get; set; }
            public string dateOfCommencementOfProductionBusiness { get; set; }
            public string dic { get; set; }
            public string msmedi { get; set; }
            public string dateOfUdyamRegistration { get; set; }
            public string typeOfEnterprise { get; set; }
        }

        public class NationalIndustryClassificationCode
        {
            public string nic2Digit { get; set; }
            public string nic4Digit { get; set; }
            public string nic5Digit { get; set; }
            public string activity { get; set; }
            public string date { get; set; }
        }

        public class OfficialAddressOfEnterprise
        {
            public string flatDoorBlockNo { get; set; }
            public string nameOfPremisesBuilding { get; set; }
            public string villageTown { get; set; }
            public string block { get; set; }
            public string roadStreetLane { get; set; }
            public string city { get; set; }
            public string state { get; set; }
            public string pin { get; set; }
            public string district { get; set; }
            public string mobile { get; set; }
            public string email { get; set; }
        }

        public class ResultUdyam
        {
            public GeneralInfo generalInfo { get; set; }
            public List<EnterpriseType> enterpriseType { get; set; }
            public List<object> unitsDetails { get; set; }
            public OfficialAddressOfEnterprise officialAddressOfEnterprise { get; set; }
            public List<NationalIndustryClassificationCode> nationalIndustryClassificationCodes { get; set; }
            public string pdfUrl { get; set; }
        }

      

    
}
