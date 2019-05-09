using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCM.Web.Business.Domain.Account
{
    public class BalanceOverviewRepository
    {

        public System.Runtime.Serialization.ExtensionDataObject extensionData { get; set; }

        public TCM.Web.Business.ProxyXFMAccount.CriteriaOptions Options { get; set; }

        public string CriteriaType { get; set; }

        public System.Nullable<System.DateTime> BalanceDate { get; set; }

        public string ViewCurrencyId { get; set; }

        public System.Nullable<long> TotalRecords { get; set; }

        public System.Collections.Generic.List<BalanceOverview> BalanceOverviewList { get; set; }

        public System.Collections.Generic.List<TCM.Web.Business.ProxyXFMAccount.GeneralCriterion> SearchCriteria { get; set; }

    }
}
