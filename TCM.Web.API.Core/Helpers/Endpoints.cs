using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TCM.Web.API.Core.Helpers
{
    public class Endpoint
    {
        public string EndPointUrl { get; set; }
        public string Name { get; set; }
    }
    public class Endpoints
    {
        List<Endpoint> EndPointList { get; set; }
    }
}
