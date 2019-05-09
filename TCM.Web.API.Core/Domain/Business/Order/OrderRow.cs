using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCM.Web.Business.Domain
{
    public partial class OrderRow
    {


        public TCM.Web.Business.ProxyXFMOrder.OrderIdentity Identity { get; set; }


        public TCM.Web.Business.ProxyXFMOrder.AggregatedOrderIdentity AggregatedOrder { get; set; }


        public TCM.Web.Business.ProxyXFMOrder.FundIdentity Fund { get; set; }


        public TCM.Web.Business.ProxyXFMOrder.AccountIdentity Account { get; set; }

        public TCM.Web.Business.ProxyXFMOrder.OrganizationIdentity Distributor { get; set; }


        public TCM.Web.Business.ProxyXFMOrder.ExternalAccountIdentity ExternalAccount { get; set; }


        public TCM.Web.Business.ProxyXFMOrder.ObjectMetaData ObjectMetaData { get; set; }

        public string OrderStatusCode { get; set; }

        public System.Nullable<int> ErrorNo { get; set; }

        public string OrderType { get; set; }


        public System.Nullable<byte> TransactionMode { get; set; }
        public string TransactionModeCode { get; set; }


        public System.Nullable<decimal> OrderAmount { get; set; }
        public System.Nullable<decimal> TradeAmount { get; set; }


        public System.Nullable<decimal> Units { get; set; }


        public System.Nullable<decimal> SettlementAmount { get; set; }


        public string OrderCurrencyId { get; set; }


        public string TradeCurrencyId { get; set; }


        public System.Nullable<decimal> ExternalFeeAmount { get; set; }


        public System.Nullable<System.DateTime> TradeDate { get; set; }


        public System.Nullable<System.DateTime> SettlementDate { get; set; }


        public System.Nullable<System.DateTime> ValueDate { get; set; }


        public System.Nullable<decimal> FundPrice { get; set; }


        public System.Nullable<decimal> CurrencyPrice { get; set; }


        public System.Nullable<bool> IsFinalised { get; set; }


        public string ObjectVersion { get; set; }


        public System.Nullable<int> ErrorNumber { get; set; }


        public string ErrorText { get; set; }


        public string ExtPosReference { get; set; }
    }
}
