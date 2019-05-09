using System;

namespace TCM.Web.API.Core.Domain
{
    public class Metadata
    {
        public string Domain { get; set; }
        public string Action { get; set; }

        public string Command { get; set; }
        public Object obj { get; set; }

        public string CorrelationId { get; set; }

    }
}