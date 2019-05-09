using System.Collections.Generic;

namespace TCM.Web.API.Core.Export2excel
{
    public class ExportInput
    {
        public List<ExportColumn> Columns { get; set; }
        public dynamic Repository { get; set; }
        public string ExportName { get; set; }
    }
}
