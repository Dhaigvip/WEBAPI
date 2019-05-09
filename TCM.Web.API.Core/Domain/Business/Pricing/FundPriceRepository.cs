namespace TCM.Web.Business.Domain
{
    using System.Runtime.Serialization;
    using System;
    using TCM.Web.Business.ProxyXFMPricing;

    public partial class FundPriceRepository
    {

        public TCM.Web.Business.ProxyXFMPricing.CriteriaOptions Options
        { get; set; }

        public string CriteriaType
        { get; set; }

        public System.Nullable<long> TotalRecords
        { get; set; }


        public System.Collections.Generic.List<FundPrice> FundPriceList
        { get; set; }


        public System.Collections.Generic.List<TCM.Web.Business.ProxyXFMPricing.GeneralCriterion> SearchCriteria
        { get; set; }


        public System.Collections.Generic.List<TCM.Web.Business.ProxyXFMPricing.SimpleCriterion> ListCriteria
        { get; set; }
        public System.Collections.Generic.List<TCM.Web.Business.ProxyXFMPricing.OrderIdentity> IdentityCriteria
        { get; set; }

    }

}