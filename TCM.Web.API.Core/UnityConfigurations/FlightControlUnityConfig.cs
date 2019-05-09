using CommonCore.Tcm.Common.UnityContainer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Unity;

namespace TCM.Web.API.Core.UnityConfigurations
{
    public class FlightControlUnityConfig : IUnityConfigure
    {
        public string Environment => "DashboardQueries";


        public IUnityContainer Init(IUnityContainer cnt)
        {
            return cnt;
        }
    }
}
