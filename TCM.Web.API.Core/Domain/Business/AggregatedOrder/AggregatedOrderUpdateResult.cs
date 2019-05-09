using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCM.Web.Business.Domain
{

    public class AggregatedOrderUpdateResult
    {

        public System.Nullable<long> AggregatedOrderId { get; set; }


        public string ExternalOrderId { get; set; }


        public System.Nullable<bool> IsApprovedToSend { get; set; }


        public System.Nullable<bool> IsConfirmed { get; set; }

        public System.Nullable<bool> IsPaid { get; set; }

        public bool? IsForced { get; set; }

        public System.Nullable<decimal> FundPrice { get; set; }


        public string FundPriceTypeId { get; set; }

        public System.Nullable<decimal> CurrencyPrice { get; set; }


        public System.Nullable<decimal> TradeAmount { get; set; }


        public System.Nullable<decimal> SettlementAmount { get; set; }


        public System.Nullable<decimal> ExternalFeeAmount { get; set; }


        public System.Nullable<decimal> Units { get; set; }


        public System.Nullable<System.DateTime> TradeDate { get; set; }


        public System.Nullable<System.DateTime> SettlementDate { get; set; }


        public System.Nullable<System.DateTime> CashSettlementDate { get; set; }


        public System.Nullable<int> ErrorNo { get; set; }


        public System.Nullable<System.DateTime> ExternalSendDate { get; set; }


        public System.Nullable<System.DateTime> ExternalResponseDate { get; set; }


        public System.Nullable<System.DateTime> PaymentSendDate { get; set; }


        public System.Nullable<System.DateTime> PaymentResponseDate { get; set; }


        public System.Nullable<System.DateTime> AccountingSendDate { get; set; }


        public System.Nullable<System.DateTime> AccountingResponseDate { get; set; }


        public string ObjectVersion { get; set; }


        public string ActionCode { get; set; }


        public System.Nullable<int> ErrorNumber { get; set; }


        public string ErrorText { get; set; }


        public string ExtPosReference { get; set; }

    }
}
