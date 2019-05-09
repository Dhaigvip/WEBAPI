namespace TCM.Web.Business.Domain
{
    using System.Runtime.Serialization;
    using System;
    using TCM.Web.Business.ProxyXFMPricing;
       

    public partial class FxOrderUpdateResult
    {


        public System.Nullable<int> FxOrderId
        { get; set; }
        public string ExternalOrderId
        { get; set; }
        public System.Nullable<bool> IsValidated
        { get; set; }
        public System.Nullable<System.DateTime> PriceDate
        { get; set; }
        public System.Nullable<decimal> CurrencyPrice
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
        public string ActionCode
        { get; set; }
        public System.Nullable<int> ErrorNumber
        { get; set; }
        public string ErrorText
        { get; set; }
        public string ExtPosReference
        { get; set; }
    }

}