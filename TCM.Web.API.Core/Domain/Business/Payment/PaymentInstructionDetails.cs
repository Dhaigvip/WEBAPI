using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCM.Web.Business.Domain
{
    public class PaymentInformationDetails
    {

        public string PaymentEntityCode { get; set; }

        public string AccountNumber { get; set; }

        public string BIC { get; set; }

        public string Bank { get; set; }

        public string ExtPosReference { get; set; }
    }
}
