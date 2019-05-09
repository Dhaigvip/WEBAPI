using CommonCore.Tcm.Common.UnityContainer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Unity;

namespace TCM.Web.API.Core.UnityConfigurations
{
    public static class TCMWebApp
    {
        public static IUnityContainer Init()
        {
            var unityContainer =
                UnityHelper.Container =
                    UnityContainerSetUp.Configure(new UnityContainer(), "Common|XfmClient|WindowsService");
            //var log = unityContainer.Resolve<CommonCore.Tcm.Common.Tcm.Logger.ILogger>();
            return unityContainer;
        }
    }
}
