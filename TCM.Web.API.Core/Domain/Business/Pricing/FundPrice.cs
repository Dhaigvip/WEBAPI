namespace TCM.Web.Business.Domain
{
    using System.Runtime.Serialization;
    using System;
    using TCM.Web.Business.ProxyXFMPricing;
    
    public partial class FundPrice
    {



        public TCM.Web.Business.ProxyXFMPricing.FundIdentity Fund
        { get; set; }

        public TCM.Web.Business.ProxyXFMPricing.ObjectMetaData ObjectMetaData
        { get; set; }


        public System.Nullable<long> FundPriceId
        { get; set; }


        public string FundPriceTypeId
        { get; set; }

        public System.Nullable<bool> IsTradeable
        { get; set; }

        public System.Nullable<System.DateTime> TradeDate
        { get; set; }
        public string CurrencyId
        { get; set; }
        public System.Nullable<decimal> FundPriceMember
        { get; set; }
        public System.Nullable<bool> IsManual
        { get; set; }
        public System.Nullable<bool> IsOverridden
        { get; set; }
        public System.Nullable<bool> IsFinal
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