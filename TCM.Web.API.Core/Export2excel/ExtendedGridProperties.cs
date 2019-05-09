using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TCM.Web.API.Core.Export2excel
{
    public class ExtendedGridProperties
    {
        private string _cultureName;
        private List<ExportColumn> _exportColumns;
        private string _exportFileNameInAsync;
        private string _extUserName;
        private string _serverMapPath;
        private string _uiCultureName;

        public string CultureName
        {
            get
            {
                return this._cultureName;
            }
            set
            {
                this._cultureName = value;
            }
        }

        public List<ExportColumn> ExportColumns
        {
            get
            {
                return this._exportColumns;
            }
            set
            {
                this._exportColumns = value;
            }
        }

        public string ExportFileNameInAsync
        {
            get
            {
                return this._exportFileNameInAsync;
            }
            set
            {
                this._exportFileNameInAsync = value;
            }
        }

        public string ExtUserName
        {
            get
            {
                return this._extUserName;
            }
            set
            {
                this._extUserName = value;
            }
        }

        public string ServerMapPath
        {
            get
            {
                return this._serverMapPath;
            }
            set
            {
                this._serverMapPath = value;
            }
        }

        public string UICultureName
        {
            get
            {
                return this._uiCultureName;
            }
            set
            {
                this._uiCultureName = value;
            }
        }
    }
}
