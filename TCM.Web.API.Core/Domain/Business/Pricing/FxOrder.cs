namespace TCM.Web.Business.Domain
{
    using System.Runtime.Serialization;
    using System;
    using TCM.Web.Business.ProxyXFMPricing;

    public partial class FxOrder
    {



        public TCM.Web.Business.ProxyXFMPricing.FxOrderIdentity Identity
        { get; set; }


        public TCM.Web.Business.ProxyXFMPricing.ObjectMetaData ObjectMetaData
        { get; set; }


        public string OrderType
        { get; set; }
        public string BaseCurrencyId
        { get; set; }
        public string QuoteCurrencyId
        { get; set; }
        public string FxSymbol
        { get; set; }
        public System.Nullable<decimal> OrderAmount
        { get; set; }
        public string OrderCurrencyId
        { get; set; }
        public System.Nullable<System.DateTime> PriceDate
        { get; set; }
        public System.Nullable<decimal> CurrencyPrice
        { get; set; }
        public System.Nullable<long> CurrencyPriceId
        { get; set; }

        public bool? IsForced { get; set; }

        public System.Nullable<bool> IsValidated
        { get; set; }
        public System.Nullable<bool> IsFinalised
        { get; set; }
        public System.Nullable<System.DateTime> ExternalSendDate
        { get; set; }
        public System.Nullable<System.DateTime> ExternalResponseDate
        { get; set; }
        public System.Nullable<System.DateTime> PaymentSendDate
        { get; set; }
        public System.Nullable<System.DateTime> PaymentResponseDate
        { get; set; }
        public System.Nullable<System.DateTime> AccountingSendDate
        { get; set; }
        public System.Nullable<System.DateTime> AccountingResponseDate
        { get; set; }
        public string ObjectVersion
        { get; set; }
        public System.Nullable<int> ErrorNumber
        { get; set; }
        public string ErrorText
        { get; set; }
        public string ExtPosReference
        { get; set; }
    }

}