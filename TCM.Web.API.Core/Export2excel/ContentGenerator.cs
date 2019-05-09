using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace TCM.Web.API.Core.Export2excel
{
    public class ContentGenerator
    {

        public IExport ExportStrategy { get; set; }
        public string ErrorMessage { get; set; }

        #region IExporter Members

        public bool Generate<T>(List<T> list, ExtendedGridProperties extendedGridProperties)
        {
            bool isError = false;
            ErrorMessage = string.Empty;

            if (!String.IsNullOrWhiteSpace(extendedGridProperties.CultureName))
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(extendedGridProperties.CultureName);
            }
            if (!String.IsNullOrWhiteSpace(extendedGridProperties.UICultureName))
            {
                Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture(extendedGridProperties.UICultureName);
            }

            if (ExportStrategy != null)
            {
                if (!ExportStrategy.Export(list, extendedGridProperties))
                {
                    isError = true;
                    ErrorMessage = "Error occured while generating the excel sheet.";
                }
            }
            else
            {              
                ErrorMessage = "Export strategy was not defined.";
            }

            return isError;
        }

        public MemoryStream GenerateExcel(System.Collections.IList list, ExtendedGridProperties extendedGridProperties)
        {

            if (!String.IsNullOrWhiteSpace(extendedGridProperties.CultureName))
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(extendedGridProperties.CultureName);
            }
            if (!String.IsNullOrWhiteSpace(extendedGridProperties.UICultureName))
            {
                Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture(extendedGridProperties.UICultureName);
            }

            if (ExportStrategy != null)
            {
                return ExportStrategy.CreateStream(list, extendedGridProperties);
            }
            else
            {
                return null;
            }
            return null;
        }
        #endregion
    }
}
