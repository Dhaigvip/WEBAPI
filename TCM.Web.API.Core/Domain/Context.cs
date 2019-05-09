using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TCM.Web.API.Core.Domain
{
    public class Context
    {
        public string ExtChannelId { get; set; }

        public string ExtId { get; set; }

        public string ExtUser { get; set; }

        public string RegUser { get; set; }

        public long? RegToken { get; set; }

        public string RegInterface { get; set; }

        public string LanguageId { get; set; }

        public string ExtPosReference { get; set; }

        public string ClientRowVersion { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? RegDate { get; set; }
    }
}
