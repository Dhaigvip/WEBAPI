using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCM.Web.Business.Domain.Account
{
    public class ExternalAccountRepository
    {



        public TCM.Web.Business.ProxyXFMAccount.CriteriaOptions Options { get; set; }
        public string CriteriaType { get; set; }
        public System.Nullable<long> TotalRecords { get; set; }
        public System.Collections.Generic.List<ExternalAccount> ExternalAccountList { get; set; }
        public System.Collections.Generic.List<TCM.Web.Business.ProxyXFMAccount.GeneralCriterion> SearchCriteria { get; set; }
        public System.Collections.Generic.List<TCM.Web.Business.ProxyXFMAccount.SimpleCriterion> ListCriteria { get; set; }
        public System.Collections.Generic.List<TCM.Web.Business.ProxyXFMAccount.ExternalAccountIdentity> IdentityCriteria { get; set; }


    }
}
