using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCM.Web.Business.Domain
{
    public class AccountMultiple
    {



        public TCM.Web.Business.ProxyXFMAccount.AccountIdentity Identity { get; set; }

        public TCM.Web.Business.ProxyXFMAccount.ObjectMetaData ObjectMetaData { get; set; }

        public System.Nullable<System.DateTime> EndDate { get; set; }

        public System.Nullable<bool> IsActive { get; set; }

        public string ObjectVersion { get; set; }

        public System.Nullable<int> ErrorNumber { get; set; }

        public string ErrorText { get; set; }

        public string ExtPosReference { get; set; }


    }
}
