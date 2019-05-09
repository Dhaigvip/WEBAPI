using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TCM.Web.API.Core.Export2excel
{
    public class ExportColumn
    {

        public string HeaderText { get; set; }

        public bool IsDate { get; set; }

        public string PropertyName { get; set; }
    }
}
