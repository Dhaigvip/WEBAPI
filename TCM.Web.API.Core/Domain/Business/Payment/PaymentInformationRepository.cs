using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCM.Web.Business.Domain
{
    public class PaymentInformationRepository
    {



        public TCM.Web.Business.ProxyXFMPayment.CriteriaOptions Options { get; set; }
        public string CriteriaType { get; set; }
        public System.Nullable<long> TotalRecords { get; set; }
        public System.Collections.Generic.List<PaymentInformation> PaymentInformationList { get; set; }
        public System.Collections.Generic.List<TCM.Web.Business.ProxyXFMPayment.GeneralCriterion> SearchCriteria { get; set; }
        //public System.Collections.Generic.List<TCM.Web.Business.ProxyXFMPayment.SimpleCriterion> ListCriteria { get; set; }
        public System.Collections.Generic.List<TCM.Web.Business.ProxyXFMPayment.PaymentInformationIdentity> IdentityCriteria { get; set; }


    }
}
