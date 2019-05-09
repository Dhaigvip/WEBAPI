using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCM.Web.Business.Domain.Account
{
    public class BalanceOverview
    {


        public TCM.Web.Business.ProxyXFMAccount.ExternalAccountIdentity ExternalAccount { get; set; }

        public TCM.Web.Business.ProxyXFMAccount.OrganizationIdentity Distributor { get; set; }

        public TCM.Web.Business.ProxyXFMAccount.FundIdentity Fund { get; set; }

        public System.Nullable<decimal> TotalUnits { get; set; }



        public System.Nullable<decimal> UnitsOnAdjustmentAccounts { get; set; }

        public System.Nullable<decimal> UnitsOnCustomerAccounts { get; set; }

        public System.Nullable<decimal> FundPrice { get; set; }

        public string PriceCurrencyId { get; set; }

        public System.Nullable<System.DateTime> PriceDate { get; set; }

        public System.Nullable<decimal> TotalValueBaseCurrency { get; set; }

        public System.Nullable<decimal> TotalValueViewCurrency { get; set; }

        public string ExtPosReference { get; set; }
    }
}
