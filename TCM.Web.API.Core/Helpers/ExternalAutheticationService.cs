using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TCM.Web.API.Core.Domain;

namespace TCM.Web.API.Core.Helpers
{
    public class ExternalAutheticationService : IAuthenticate
    {
        public bool Authenticate(UserCredentials userCredentials)
        {
            return true;
        }

       
    }
}
