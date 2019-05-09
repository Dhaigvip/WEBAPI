using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCM.Web.Business.Domain
{

    public class AggregatedOrderRow
    {

        public AggregatedOrderRow()
        {
          
        }

        public TCM.Web.Business.ProxyXFMAggregatedOrder.AggregatedOrderIdentity Identity { get; set; }
        public TCM.Web.Business.ProxyXFMAggregatedOrder.FundIdentity Fund { get; set; }
        public TCM.Web.Business.ProxyXFMAggregatedOrder.ExternalAccountIdentity ExternalAccount { get; set; }
        public TCM.Web.Business.ProxyXFMAggregatedOrder.OrganizationIdentity Distributor { get; set; }

        public TCM.Web.Business.ProxyXFMAggregatedOrder.PaymentInformationIdentity PaymentInformation { get; set; }

        public TCM.Web.Business.ProxyXFMAggregatedOrder.ObjectMetaData ObjectMetaData { get; set; }
        public string OrderStatusCode { get; set; }
        public System.Nullable<int> ErrorNo { get; set; }
        public string OrderType { get; set; }
        public System.Nullable<byte> TransactionMode { get; set; }
        
        public string TransactionModeCode { get; set; }
        public string OrderPlacementCode { get; set; }

        public System.Nullable<decimal> OrderAmount { get; set; }
        public System.Nullable<decimal> Units { get; set; }
        public string OrderCurrencyId { get; set; }
        public string TradeCurrencyId { get; set; }
        public System.Nullable<decimal> CurrencyPrice { get; set; }
        public System.Nullable<long> FundPriceId { get; set; }
        public System.Nullable<decimal> FundPrice { get; set; }

        public string FundPriceTypeId { get; set; }

        public System.Nullable<decimal> TradeAmount { get; set; }
        public System.Nullable<decimal> ExternalFeeAmount { get; set; }

        public System.Nullable<decimal> SettlementAmount { get; set; }



        public System.Nullable<System.DateTime> TradeDate { get; set; }
        public System.Nullable<System.DateTime> SettlementDate { get; set; }

        public string StatusInformation { get; set; }
        
        
        
        public System.Nullable<System.DateTime> CashSettlementDate { get; set; }
        public System.Nullable<bool> IsApprovedToSend { get; set; }

        public System.Nullable<bool> IsPaid { get; set; }

        public System.Nullable<bool> IsConfirmed { get; set; }
        public System.Nullable<bool> IsFinalised { get; set; }
        
        public System.Nullable<bool> IsForced { get; set; }
        public System.Nullable<System.DateTime> ExternalSendDate { get; set; }
        public System.Nullable<System.DateTime> ExternalResponseDate { get; set; }
        public System.Nullable<System.DateTime> PaymentSendDate { get; set; }
        public System.Nullable<System.DateTime> PaymentResponseDate { get; set; }
        public System.Nullable<System.DateTime> AccountingSendDate { get; set; }
        public System.Nullable<System.DateTime> AccountingResponseDate { get; set; }
        public string ObjectVersion { get; set; }
        public System.Nullable<int> ErrorNumber { get; set; }
        public string ErrorText { get; set; }
        public string ExtPosReference { get; set; }
    }
}
