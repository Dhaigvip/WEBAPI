using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCM.Web.Business.Domain
{
    public class AggregatedOrderRepository
    {



        public TCM.Web.Business.ProxyXFMAggregatedOrder.CriteriaOptions Options { get; set; }
        public string CriteriaType { get; set; }
        public System.Nullable<long> TotalRecords { get; set; }
        public System.Collections.Generic.List<AggregatedOrderRow> AggregatedOrderList { get; set; }
        public System.Collections.Generic.List<TCM.Web.Business.ProxyXFMAggregatedOrder.GeneralCriterion> SearchCriteria { get; set; }
        public System.Collections.Generic.List<TCM.Web.Business.ProxyXFMAggregatedOrder.SimpleCriterion> ListCriteria { get; set; }
        public System.Collections.Generic.List<TCM.Web.Business.ProxyXFMAggregatedOrder.AggregatedOrderIdentity> IdentityCriteria { get; set; }


    }
}
