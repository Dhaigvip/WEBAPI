using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCM.Web.Business.Domain
{
    //public class OrderRepository
    //{   
    //    public CriteriaOptions Options { get; set; }
    //    public string CriteriaType { get; set; }
    //    public System.Nullable<long> TotalRecords { get; set; }
    //    public System.Collections.Generic.List<OrderRow> OrderList { get; set; }
    //    public System.Collections.Generic.List<GeneralCriterion> SearchCriteria { get; set; }
    //    public System.Collections.Generic.List<SimpleCriterion> ListCriteria { get; set; }
    //    public System.Collections.Generic.List<TCM.Web.Business.ProxyXFMOrder.OrderIdentity> IdentityCriteria { get; set; }

    //}


    public class OrderRepository
    {
        public TCM.Web.Business.ProxyXFMOrder.CriteriaOptions Options { get; set; }
        public string CriteriaType { get; set; }
        public System.Nullable<long> TotalRecords { get; set; }
        public List<OrderRow> OrderList { get; set; }
        public List<TCM.Web.Business.ProxyXFMOrder.GeneralCriterion> SearchCriteria { get; set; }
        //public List<TCM.Web.Business.ProxyXFMOrder.SimpleCriterion> ListCriteria { get; set; }
        public List<TCM.Web.Business.ProxyXFMOrder.OrderIdentity> IdentityCriteria { get; set; }

    }

}
