using System.Collections.Generic;

using TCM.Web.Business.Domain;
using TCM.Web.Business.Domain.Fund;

namespace TCM.Web.Business.Domain
{
    

    public class FundRepository
    {
        public TCM.Web.Business.ProxyXFMFund.CriteriaOptions Options { get; set; }
        public string CriteriaType { get; set; }
        public System.Nullable<long> TotalRecords { get; set; }
        public System.Collections.Generic.List<FundInfo> FundList { get; set; }
        public System.Collections.Generic.List<TCM.Web.Business.ProxyXFMFund.GeneralCriterion> SearchCriteria { get; set; }
        public System.Collections.Generic.List<TCM.Web.Business.ProxyXFMFund.SimpleCriterion> ListCriteria { get; set; }
        public System.Collections.Generic.List<TCM.Web.Business.ProxyXFMFund.FundIdentity> IdentityCriteria { get; set; }


    }
}