using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TCM.Web.API.Core.Domain
{
    public class TCMClientResponse
    {
        public object Data { get; set; }

        public bool Success { get; set; }
        List<Error> ErrorList { get; set; }
    }
}
