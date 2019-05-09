using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCM.Web.Business.Domain.Booking
{
    public class BookingOverviewRepository
    {


        public TCM.Web.Business.ProxyBooking.CriteriaOptions Options { get; set; }

        public string CriteriaType { get; set; }

        public System.Nullable<long> TotalRecords { get; set; }

        public System.Collections.Generic.List<BookingOverview> BookingOverviewList { get; set; }

        public System.Collections.Generic.List<TCM.Web.Business.ProxyBooking.GeneralCriterion> SearchCriteria { get; set; }

    }
}
