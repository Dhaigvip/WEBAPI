using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCM.Web.Business.Domain.UserSettings
{
    public class UserSettings
    {

        public System.Nullable<int> Id { get; set; }

        public string UserId { get; set; }

        public bool Public { get; set; }

        public string Data { get; set; }

        public byte[] ObjectVersionField { get; set; }
    }
}
