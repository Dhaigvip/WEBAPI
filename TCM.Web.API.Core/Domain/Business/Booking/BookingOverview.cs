using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCM.Web.Business.Domain.Booking
{
    public class BookingOverview
    {



        public System.Nullable<long> DepositReferenceId { get; set; }


        public string EntityCode { get; set; }


        public System.Nullable<long> EntityId { get; set; }


        public string BatchId { get; set; }


        public System.Nullable<long> BookingMovementId { get; set; }


        public System.Nullable<int> BookingGroupId { get; set; }


        public string BookingDirection { get; set; }


        public string AccountNumber { get; set; }


        public System.Nullable<decimal> Amount { get; set; }


        public string CurrencyId { get; set; }


        public System.Nullable<System.DateTime> ValueDate { get; set; }


        public string ExtReference { get; set; }


        public System.Nullable<System.DateTime> ProcessingDate { get; set; }


        public System.Nullable<bool> IsExported { get; set; }


        public string StatusCode { get; set; }

        public string Note { get; set; }

        public string StatusReference { get; set; }
        public string ExtPosReference { get; set; }
    }
}
