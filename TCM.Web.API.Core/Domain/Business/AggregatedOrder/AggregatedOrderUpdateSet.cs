using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCM.Web.Business.Domain
{
    public class AggregatedOrderUpdateSet
    {
        public System.Collections.Generic.List<AggregatedOrderUpdate> AggregatedOrderUpdateList { get; set; }

        public System.Collections.Generic.List<AggregatedOrderUpdateResult> AggregatedOrderUpdateResultList { get; set; }
    }

    
}
