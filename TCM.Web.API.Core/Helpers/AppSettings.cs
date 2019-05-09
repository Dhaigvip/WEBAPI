using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TCM.Web.API.Core.Helpers
{
    public class AppSettings
    {
        public string Secret { get; set; }
        public string ExcelExportPath { get; set; }

        public string ExtChannelId { get; set; }

        public string ExtId { get; set; }
        public string RegToken { get; set; }

        public string RegInterface { get; set; }
        public string LanguageId { get; set; }

        public string Environment { get; set; }

        public bool LoadFlightControl { get; set; }
        
    }
}
