using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCM.Web.Business.Domain.Order
{
    public class Order
    {

        public System.Runtime.Serialization.ExtensionDataObject extensionData { get; set; }


        public TCM.Web.Business.ProxyXFMOrder.FundIdentity Fund { get; set; }


        public TCM.Web.Business.ProxyXFMOrder.AccountIdentity Account { get; set; }


        public TCM.Web.Business.ProxyXFMOrder.OrderValue Value { get; set; }


        public System.Nullable<long> OrderGroupId { get; set; }


        public string ExternalOrderId { get; set; }


        public string ExternalBatchId { get; set; }


        public string OrderCurrencyId { get; set; }


        public System.Nullable<System.DateTime> SettlementDate { get; set; }


        public System.Nullable<System.DateTime> ValueDate { get; set; }


        public System.Collections.Generic.List<OrderRow> OrderResultList { get; set; }

    }
}
