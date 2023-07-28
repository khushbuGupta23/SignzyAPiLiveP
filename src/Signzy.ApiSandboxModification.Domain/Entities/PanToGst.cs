using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signzy.ApiSandboxModification.Domain.Entities
{
    public class PanToGst
    {
        public string task { get; set; }
        public EssentialsPAN essentials { get; set; }
        public string id { get; set; }
        public string patronId { get; set; }
        public ResultPAN result { get; set; }

    }
   

    public class PanToGstResponse
    {
        public string task { get; set; }
        public EssentialsPAN essentials { get; set; }
    }
    public class EssentialsPAN
    {
        public string panNumber { get; set; }
        public string? state { get; set; }
        public string? email { get; set; }
    }
    public class ResultPAN
    {
        public List<GstnDetailed> gstnDetailed { get; set; }
        public List<GstnRecord> gstnRecords { get; set; }
        public string gstin { get; set; }
    }
    public class GstnRecord
    {
        public string applicationStatus { get; set; }
        public string registrationName { get; set; }
        public string mobNum { get; set; }
        public string regType { get; set; }
        public string emailId { get; set; }
        public string tinNumber { get; set; }
        public string gstinRefId { get; set; }
        public string gstin { get; set; }
    }

   
    public class GstnDetailed
    {
        public string constitutionOfBusiness { get; set; }
        public string legalNameOfBusiness { get; set; }
        public string tradeNameOfBusiness { get; set; }
        public string centreJurisdiction { get; set; }
        public string stateJurisdiction { get; set; }
        public string registrationDate { get; set; }
        public string taxPayerDate { get; set; }
        public string taxPayerType { get; set; }
        public string gstinStatus { get; set; }
        public string cancellationDate { get; set; }

        [JsonProperty("e-invoicingStatus")]
        public string einvoicingStatus { get; set; }
        public List<string> natureOfBusinessActivities { get; set; }
        public string principalPlaceAddress { get; set; }
        public string principalPlaceLatitude { get; set; }
        public string principalPlaceLongitude { get; set; }
        public string principalPlaceBuildingNameFromGST { get; set; }
        public string principalPlaceBuildingNoFromGST { get; set; }
        public string principalPlaceFlatNo { get; set; }
        public string principalPlaceStreet { get; set; }
        public string principalPlaceLocality { get; set; }
        public string principalPlaceCity { get; set; }
        public string principalPlaceDistrict { get; set; }
        public string principalPlaceState { get; set; }
        public string principalPlacePincode { get; set; }
        public string additionalPlaceAddress { get; set; }
        public string additionalPlaceLatitude { get; set; }
        public string additionalPlaceLongitude { get; set; }
        public string additionalPlaceBuildingNameFromGST { get; set; }
        public string additionalPlaceBuildingNoFromGST { get; set; }
        public string additionalPlaceFlatNo { get; set; }
        public string additionalPlaceStreet { get; set; }
        public string additionalPlaceLocality { get; set; }
        public string additionalPlaceCity { get; set; }
        public string additionalPlaceDistrict { get; set; }
        public string additionalPlaceState { get; set; }
        public string additionalPlacePincode { get; set; }
        public List<object> additionalAddressArray { get; set; }
        public string lastUpdatedDate { get; set; }
        public PrincipalPlaceSplitAddress principalPlaceSplitAddress { get; set; }
        public AdditionalPlaceSplitAddress additionalPlaceSplitAddress { get; set; }
    } 
    public class AdditionalPlaceSplitAddress
    {
        public List<object> district { get; set; }
        public List<List<object>> state { get; set; }
        public List<object> city { get; set; }
        public string pincode { get; set; }
        public List<string> country { get; set; }
        public string addressLine { get; set; }
    }
    public class PrincipalPlaceSplitAddress
    {
        public List<string> district { get; set; }
        public List<List<string>> state { get; set; }
        public List<string> city { get; set; }
        public string pincode { get; set; }
        public List<string> country { get; set; }
        public string addressLine { get; set; }
    }


}
