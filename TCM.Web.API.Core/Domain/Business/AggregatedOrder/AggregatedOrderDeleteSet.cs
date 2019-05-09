using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCM.Web.Business.Domain.AggregatedOrder
{




    public partial class AggregatedOrderDeleteResult
    {

        public System.Runtime.Serialization.ExtensionDataObject extensionData { get; set; }

        public System.Nullable<long> AggregatedOrderId { get; set; }

        public string ObjectVersion { get; set; }

        public string ActionCode { get; set; }

        public System.Nullable<int> ErrorNumber { get; set; }

        public string ErrorText { get; set; }

        public string ExtPosReference { get; set; }
    }


    public class AggregatedOrderDelete
    {

        public System.Nullable<long> AggregatedOrderId { get; set; }

        public string ObjectVersion { get; set; }

        public string ExtPosReference { get; set; }
    }


    public class AggregatedOrderDeleteSet
    {

        public System.Collections.Generic.List<AggregatedOrderDelete> AggregatedOrderDeleteList { get; set; }


        public System.Collections.Generic.List<AggregatedOrderDeleteResult> AggregatedOrderDeleteResultList { get; set; }
    }
}
