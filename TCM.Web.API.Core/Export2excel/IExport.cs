using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace TCM.Web.API.Core.Export2excel
{
    public interface IExport
    {
        bool Export<T>(List<T> list, ExtendedGridProperties extendedGridProperties);

        MemoryStream CreateStream(System.Collections.IList list, ExtendedGridProperties extendedGridProperties);
    }
}
