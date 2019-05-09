namespace TCM.Web.Business.Domain
{
    using System.Runtime.Serialization;
    using System;
    using TCM.Web.Business.ProxyXFMPricing;
    

    public partial class FxOrderUpdateSet
    {



        public System.Collections.Generic.List<FxOrderUpdates> FxOrderUpdateList
        { get; set; }

        public System.Collections.Generic.List<FxOrderUpdateResult> FxOrderUpdateResultList
        { get; set; }
    }

}