using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCM.Web.Business.Domain.Organisation
{


    public class OrganizationInfo
    {


        public TCM.Web.Business.ProxyXFMOrganization.OrganizationIdentity Identity { get; set; }


        public TCM.Web.Business.ProxyXFMOrganization.ObjectMetaData ObjectMetaData { get; set; }


        public System.Nullable<bool> IsFundCompany { get; set; }


        public System.Nullable<bool> IsDistributor { get; set; }


        public string ContactName { get; set; }


        public string ContactPhone { get; set; }


        public string ContactFax { get; set; }


        public string ContactEmail { get; set; }


        public string OrderPlacementCode { get; set; }


        public string OrderBIC { get; set; }

        public string DistinguishedName { get; set; }

        public string BankName { get; set; }


        public string OrderPhone { get; set; }


        public string OrderFax { get; set; }


        public string OrderEmail { get; set; }


        public string DivisionName { get; set; }


        public string Attention { get; set; }


        public string CoAddress { get; set; }


        public string DistributionAddress1 { get; set; }


        public string DistributionAddress2 { get; set; }


        public string PostalCodeId { get; set; }


        public string CityName { get; set; }


        public string StateName { get; set; }


        public string CountryId { get; set; }

        public string Culture { get; set; }

        public System.Nullable<System.DateTime> EndDate { get; set; }


        public string ObjectVersion { get; set; }


        public string ExtPosReference { get; set; }

    }


    public partial class OrganizationSaveResult
    {




        public TCM.Web.Business.ProxyXFMOrganization.OrganizationIdentity Identity { get; set; }


        public TCM.Web.Business.ProxyXFMOrganization.ObjectMetaData ObjectMetaData { get; set; }


        public System.Nullable<bool> IsFundCompany { get; set; }


        public System.Nullable<bool> IsDistributor { get; set; }


        public string ContactName { get; set; }


        public string ContactPhone { get; set; }


        public string ContactFax { get; set; }


        public string ContactEmail { get; set; }


        public string OrderPlacementCode { get; set; }


        public string OrderBIC { get; set; }


        public string BankName { get; set; }

        public string DistinguishedName { get; set; }

        public string OrderPhone { get; set; }


        public string OrderFax { get; set; }


        public string OrderEmail { get; set; }


        public string DivisionName { get; set; }


        public string Attention { get; set; }


        public string CoAddress { get; set; }


        public string DistributionAddress1 { get; set; }


        public string DistributionAddress2 { get; set; }


        public string PostalCodeId { get; set; }


        public string CityName { get; set; }


        public string StateName { get; set; }


        public string CountryId { get; set; }

        public string Culture { get; set; }
        public System.Nullable<System.DateTime> EndDate { get; set; }


        public string ObjectVersion { get; set; }


        public string ActionCode { get; set; }


        public System.Nullable<int> ErrorNumber { get; set; }


        public string ErrorText { get; set; }


        public string ExtPosReference { get; set; }

    }

    public class OrganizationSaveSet
    {

        public System.Collections.Generic.List<OrganizationInfo> OrganizationList { get; set; }

        public System.Collections.Generic.List<OrganizationSaveResult> OrganizationResultList { get; set; }

    }
}
