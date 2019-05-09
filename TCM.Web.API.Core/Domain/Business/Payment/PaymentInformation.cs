using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCM.Web.Business.Domain
{
    public class PaymentInformation
    {

        public System.Runtime.Serialization.ExtensionDataObject extensionData { get; set; }

        public TCM.Web.Business.ProxyXFMPayment.PaymentInformationIdentity Identity { get; set; }

        public TCM.Web.Business.ProxyXFMPayment.OrganizationIdentity Distributor { get; set; }

        public string MessageToReceiver { get; set; }

        public string ChargeBearer { get; set; }

        public System.Nullable<System.DateTime> ValidFrom { get; set; }

        public System.Nullable<System.DateTime> ValidTo { get; set; }

        public System.Nullable<bool> Approve { get; set; }

        public string ObjectVersion { get; set; }

        public System.Nullable<bool> IsActive { get; set; }

        public System.Nullable<bool> IsApproved { get; set; }

        public System.Nullable<System.DateTime> ApprovedDate { get; set; }

        public System.Collections.Generic.List<TCM.Web.Business.ProxyXFMPayment.FundIdentity> FundList { get; set; }

        public System.Collections.Generic.List<PaymentInformationDetails> PaymentInformationDetailList { get; set; }


    }
}
