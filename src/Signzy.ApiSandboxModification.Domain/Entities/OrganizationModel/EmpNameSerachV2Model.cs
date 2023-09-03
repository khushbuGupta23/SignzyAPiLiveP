using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signzy.ApiSandboxModification.Domain.Entities.OrganizationModel
{
    public class EmpNameSerachV2Model
    {
        public ResultENSV result { get; set; }
        public ErrorsENSV error { get; set; }
    }
    public class PaymentDetail
    {
        public string trrn { get; set; }
        public string dateOfCredit { get; set; }
        public string amount { get; set; }
        public string wageMonth { get; set; }
        public string ecr { get; set; }
        public List<string> employeeMatch { get; set; }
    }

    public class ResultENSV
    {
        public string match { get; set; }
        public List<SearchResult> searchResult { get; set; }
    }

    public class SearchResult
    {
        public string establishmentName { get; set; }
        public string establishmentID { get; set; }
        public string address { get; set; }
        public string officeName { get; set; }
        public List<PaymentDetail> paymentDetails { get; set; }
    }

    public class EssentialsENSV
    {
        public string establishmentId { get; set; }
        public string establishmentName { get; set; }
        public string employeeName { get; set; }
        public string employmentMonth { get; set; }
    }

    public class ENSVInput
    {
        public string task { get; set; }
        public EssentialsENSV essentials { get; set; }
    }

    public class ErrorsENSV
    {
        public int statusCode { get; set; }
        public string name { get; set; }
        public string message { get; set; }
        public int status { get; set; }
    }

}
