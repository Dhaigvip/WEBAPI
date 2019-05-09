namespace TCM.Web.Business.Domain
{
    using System.Runtime.Serialization;
    using System;
    using TCM.Web.Business.ProxyXFMPricing;



    public partial class FundPriceSaveInput
    {




        public TCM.Web.Business.ProxyXFMPricing.FundIdentity Fund { get; set; }


        public System.Nullable<long> FundPriceId { get; set; }


        public string FundPriceTypeId { get; set; }


        public System.Nullable<System.DateTime> TradeDate { get; set; }


        public string CurrencyId { get; set; }


        public System.Nullable<decimal> FundPrice { get; set; }


        public System.Nullable<bool> IsOverridden { get; set; }


        public System.Nullable<bool> IsFinal { get; set; }


        public string ObjectVersion { get; set; }


        public string ExtPosReference { get; set; }
    }






    public partial class FundPriceSaveSet
    {

        public System.Collections.Generic.List<FundPriceSaveInput> FundPriceList
        { get; set; }

        public System.Collections.Generic.List<FundPriceSaveResult> FundPriceSaveResultList
        { get; set; }

    }

}