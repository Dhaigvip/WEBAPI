using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCM.Web.Business.Domain.Fund
{


   


    public class FundOverviewRepository
    {

        public System.Runtime.Serialization.ExtensionDataObject extensionData { get; set; }

        public TCM.Web.Business.ProxyXFMFund.CriteriaOptions Options { get; set; }

        public string CriteriaType { get; set; }

        public System.Nullable<long> TotalRecords { get; set; }

        public System.Collections.Generic.List<FundOverview> FundList { get; set; }

        public System.Collections.Generic.List<TCM.Web.Business.ProxyXFMFund.GeneralCriterion> SearchCriteria { get; set; }

        public System.Collections.Generic.List<TCM.Web.Business.ProxyXFMFund.SimpleCriterion> ListCriteria { get; set; }

        public System.Collections.Generic.List<TCM.Web.Business.ProxyXFMFund.FundIdentity> IdentityCriteria { get; set; }

    }




    public partial class FundOverview
    {

        public System.Runtime.Serialization.ExtensionDataObject extensionData { get; set; }


        public TCM.Web.Business.ProxyXFMFund.FundIdentity Identity { get; set; }


        public TCM.Web.Business.ProxyXFMFund.OrganizationIdentity FundCompany { get; set; }


        public TCM.Web.Business.ProxyXFMFund.OrganizationIdentity Distributor { get; set; }


        public TCM.Web.Business.ProxyXFMFund.FundIdentifier Identifiers { get; set; }


        public TCM.Web.Business.ProxyXFMFund.ObjectMetaData ObjectMetaData { get; set; }


        public string FundTypeCode { get; set; }


        public string ExternalIdSource { get; set; }


        public string DomicileCountryId { get; set; }


        public string UmbrellaName { get; set; }


        public string DistributionPolicyCode { get; set; }


        public string DividendPolicyCode { get; set; }


        public string DividendFrequencyCode { get; set; }


        public System.Nullable<bool> HasFrontEndLoad { get; set; }


        public System.Nullable<bool> HasBackEndLoad { get; set; }


        public System.Nullable<bool> HasSwitchFee { get; set; }


        public string EUSDCode { get; set; }


        public string ValuationFrequency { get; set; }


        public string ValuationDescription { get; set; }


        public System.Nullable<byte> UnitsScale { get; set; }


        public System.Nullable<bool> UnitsDoTruncate { get; set; }


        public System.Nullable<byte> PriceScale { get; set; }


        public System.Nullable<decimal> MinInitialSubscriptionAmount { get; set; }


        public System.Nullable<decimal> MinSubsequentSubscriptionAmount { get; set; }


        public System.Nullable<decimal> MinInitialSubscriptionUnits { get; set; }


        public System.Nullable<decimal> MinSubsequentSubscriptionUnits { get; set; }


        public System.Nullable<decimal> MinRedemptionAmount { get; set; }


        public System.Nullable<decimal> MinRedemptionUnits { get; set; }


        public System.Nullable<decimal> MaxRedemptionAmount { get; set; }


        public System.Nullable<decimal> MaxRedemptionUnits { get; set; }


        public string OtherRedemptionRestrictions { get; set; }


        public string IsTransferAllowedCode { get; set; }


        public System.Nullable<decimal> MinHoldingAmount { get; set; }


        public System.Nullable<decimal> MinHoldingUnits { get; set; }


        public System.Nullable<bool> IsSubscriptionAmountAllowed { get; set; }


        public System.Nullable<bool> IsSubscriptionUnitsAllowed { get; set; }


        public System.Nullable<bool> IsRedemptionAmountAllowed { get; set; }


        public System.Nullable<bool> IsRedemptionUnitsAllowed { get; set; }


        public string SubscriptionCutOffTime { get; set; }


        public string SubscriptionCutOffTimeHalfDay { get; set; }


        public System.Nullable<byte> SubscriptionTradeMinusDays { get; set; }


        public string SubscriptionFrequency { get; set; }


        public string RedemptionCutOffTime { get; set; }


        public string RedemptionCutOffTimeHalfDay { get; set; }


        public System.Nullable<byte> RedemptionTradeMinusDays { get; set; }


        public string RedemptionFrequency { get; set; }


        public System.Nullable<bool> IsPrepaid { get; set; }


        public System.Nullable<int> SubscriptionSettlementDays { get; set; }


        public System.Nullable<int> RedemptionSettlementDays { get; set; }


        public System.Nullable<bool> IsOrderAllowed { get; set; }


        public System.Nullable<System.DateTime> EndDate { get; set; }


        public string ObjectVersion { get; set; }


        public System.Nullable<decimal> LatestNav { get; set; }


        public System.Nullable<System.DateTime> LatestNavDate { get; set; }


        public System.Nullable<bool> IsActive { get; set; }


        public string ExtPosReference { get; set; }
    }

    public class FundInfo
    {

        public System.Runtime.Serialization.ExtensionDataObject extensionData { get; set; }


        public TCM.Web.Business.ProxyXFMFund.FundIdentity Identity { get; set; }


        public TCM.Web.Business.ProxyXFMFund.OrganizationIdentity FundCompany { get; set; }


        public TCM.Web.Business.ProxyXFMFund.OrganizationIdentity Distributor { get; set; }


        public TCM.Web.Business.ProxyXFMFund.FundIdentifier Identifiers { get; set; }


        public TCM.Web.Business.ProxyXFMFund.ObjectMetaData ObjectMetaData { get; set; }


        public string FundTypeCode { get; set; }


        public string ExternalIdSource { get; set; }


        public string DomicileCountryId { get; set; }


        public string UmbrellaName { get; set; }


        public string DistributionPolicyCode { get; set; }


        public string DividendPolicyCode { get; set; }


        public string DividendFrequencyCode { get; set; }


        public System.Nullable<bool> HasFrontEndLoad { get; set; }


        public System.Nullable<bool> HasBackEndLoad { get; set; }


        public System.Nullable<bool> HasSwitchFee { get; set; }


        public string EUSDCode { get; set; }


        public string ValuationFrequency { get; set; }


        public string ValuationDescription { get; set; }


        public System.Nullable<byte> UnitsScale { get; set; }


        public System.Nullable<bool> UnitsDoTruncate { get; set; }


        public System.Nullable<byte> PriceScale { get; set; }


        public System.Nullable<decimal> MinInitialSubscriptionAmount { get; set; }


        public System.Nullable<decimal> MinSubsequentSubscriptionAmount { get; set; }


        public System.Nullable<decimal> MinInitialSubscriptionUnits { get; set; }


        public System.Nullable<decimal> MinSubsequentSubscriptionUnits { get; set; }


        public System.Nullable<decimal> MinRedemptionAmount { get; set; }


        public System.Nullable<decimal> MinRedemptionUnits { get; set; }


        public System.Nullable<decimal> MaxRedemptionAmount { get; set; }


        public System.Nullable<decimal> MaxRedemptionUnits { get; set; }


        public string OtherRedemptionRestrictions { get; set; }


        public string IsTransferAllowedCode { get; set; }


        public System.Nullable<decimal> MinHoldingAmount { get; set; }


        public System.Nullable<decimal> MinHoldingUnits { get; set; }


        public System.Nullable<bool> IsSubscriptionAmountAllowed { get; set; }


        public System.Nullable<bool> IsSubscriptionUnitsAllowed { get; set; }


        public System.Nullable<bool> IsRedemptionAmountAllowed { get; set; }


        public System.Nullable<bool> IsRedemptionUnitsAllowed { get; set; }


        public string SubscriptionCutOffTime { get; set; }


        public string SubscriptionCutOffTimeHalfDay { get; set; }


        public System.Nullable<byte> SubscriptionTradeMinusDays { get; set; }


        public string SubscriptionFrequency { get; set; }


        public string RedemptionCutOffTime { get; set; }


        public string RedemptionCutOffTimeHalfDay { get; set; }


        public System.Nullable<byte> RedemptionTradeMinusDays { get; set; }


        public string RedemptionFrequency { get; set; }


        public System.Nullable<bool> IsPrepaid { get; set; }


        public System.Nullable<bool> IsActive { get; set; }

        public System.Nullable<int> SubscriptionSettlementDays { get; set; }


        public System.Nullable<int> RedemptionSettlementDays { get; set; }


        public System.Nullable<bool> IsOrderAllowed { get; set; }


        public System.Nullable<System.DateTime> EndDate { get; set; }


        public string ObjectVersion { get; set; }


        public string ExtPosReference { get; set; }
    }


    public partial class FundSaveResult
    {



        public TCM.Web.Business.ProxyXFMFund.FundIdentity Identity { get; set; }


        public TCM.Web.Business.ProxyXFMFund.OrganizationIdentity FundCompany { get; set; }


        public TCM.Web.Business.ProxyXFMFund.OrganizationIdentity Distributor { get; set; }


        public TCM.Web.Business.ProxyXFMFund.FundIdentifier Identifiers { get; set; }


        public TCM.Web.Business.ProxyXFMFund.ObjectMetaData ObjectMetaData { get; set; }


        public string FundTypeCode { get; set; }


        public string ExternalIdSource { get; set; }


        public string DomicileCountryId { get; set; }


        public string UmbrellaName { get; set; }


        public string DistributionPolicyCode { get; set; }


        public string DividendPolicyCode { get; set; }


        public string DividendFrequencyCode { get; set; }


        public System.Nullable<bool> HasFrontEndLoad { get; set; }


        public System.Nullable<bool> HasBackEndLoad { get; set; }


        public System.Nullable<bool> HasSwitchFee { get; set; }


        public string EUSDCode { get; set; }


        public string ValuationFrequency { get; set; }


        public string ValuationDescription { get; set; }


        public System.Nullable<byte> UnitsScale { get; set; }


        public System.Nullable<bool> UnitsDoTruncate { get; set; }


        public System.Nullable<byte> PriceScale { get; set; }


        public System.Nullable<decimal> MinInitialSubscriptionAmount { get; set; }


        public System.Nullable<decimal> MinSubsequentSubscriptionAmount { get; set; }


        public System.Nullable<decimal> MinInitialSubscriptionUnits { get; set; }


        public System.Nullable<decimal> MinSubsequentSubscriptionUnits { get; set; }


        public System.Nullable<decimal> MinRedemptionAmount { get; set; }


        public System.Nullable<decimal> MinRedemptionUnits { get; set; }


        public System.Nullable<decimal> MaxRedemptionAmount { get; set; }


        public System.Nullable<decimal> MaxRedemptionUnits { get; set; }


        public string OtherRedemptionRestrictions { get; set; }


        public string IsTransferAllowedCode { get; set; }


        public System.Nullable<decimal> MinHoldingAmount { get; set; }


        public System.Nullable<decimal> MinHoldingUnits { get; set; }


        public System.Nullable<bool> IsSubscriptionAmountAllowed { get; set; }


        public System.Nullable<bool> IsSubscriptionUnitsAllowed { get; set; }


        public System.Nullable<bool> IsRedemptionAmountAllowed { get; set; }


        public System.Nullable<bool> IsRedemptionUnitsAllowed { get; set; }


        public string SubscriptionCutOffTime { get; set; }


        public string SubscriptionCutOffTimeHalfDay { get; set; }


        public System.Nullable<byte> SubscriptionTradeMinusDays { get; set; }


        public string SubscriptionFrequency { get; set; }


        public string RedemptionCutOffTime { get; set; }


        public string RedemptionCutOffTimeHalfDay { get; set; }


        public System.Nullable<byte> RedemptionTradeMinusDays { get; set; }


        public string RedemptionFrequency { get; set; }


        public System.Nullable<bool> IsPrepaid { get; set; }


        public System.Nullable<int> SubscriptionSettlementDays { get; set; }


        public System.Nullable<int> RedemptionSettlementDays { get; set; }


        public System.Nullable<bool> IsOrderAllowed { get; set; }


        public System.Nullable<System.DateTime> EndDate { get; set; }


        public string ObjectVersion { get; set; }


        public string ActionCode { get; set; }


        public System.Nullable<int> ErrorNumber { get; set; }


        public string ErrorText { get; set; }


        public string ExtPosReference { get; set; }
    }




    public partial class FundSaveSet
    {

        public System.Collections.Generic.List<FundInfo> FundList { get; set; }

        public System.Collections.Generic.List<FundSaveResult> FundResultList { get; set; }
    }

}
