using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TCM.Web.API.Core.Domain
{
    public class TCMClientRequest
    {
        /// <summary>
        /// Users context
        /// </summary>
        public Context Context { get; set; }

        /// <summary>
        /// Any additional information like which manager, action to be executed. 
        /// </summary>
        public Metadata MetaData { get; set; }

        /// <summary>
        /// Actual payload of the request.
        /// </summary>
        public object Data { get; set; }
    }
}
