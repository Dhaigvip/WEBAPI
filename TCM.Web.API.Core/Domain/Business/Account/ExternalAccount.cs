using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCM.Web.Business.Domain
{
    public class ExternalAccount
    {

        public System.Runtime.Serialization.ExtensionDataObject extensionData { get; set; }

        public TCM.Web.Business.ProxyXFMAccount.ExternalAccountIdentity Identity { get; set; }

        public TCM.Web.Business.ProxyXFMAccount.OrganizationIdentity Distributor { get; set; }

        public TCM.Web.Business.ProxyXFMAccount.AccountIdentity AdjustmentAccount { get; set; }

        //public System.Nullable<bool> DirectCustomer { get; set; }
        public TCM.Web.Business.ProxyXFMAccount.Intermediary RelatedParty { get; set; }

        public System.Nullable<bool> Activate { get; set; }

        public System.Nullable<bool> Deactivate { get; set; }

        public string ObjectVersion { get; set; }

        public System.Nullable<bool> IsActive { get; set; }

        public System.Collections.Generic.List<TCM.Web.Business.ProxyXFMAccount.FundIdentity> FundList { get; set; }

        public System.Collections.Generic.List<TCM.Web.Business.ProxyXFMAccount.AccountIdentity> AccountList { get; set; }



    }
}
