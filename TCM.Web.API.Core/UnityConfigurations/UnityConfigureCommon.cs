using CommonCore.Tcm.Common.UnityContainer;
using CommonCore.Tcm.Logger;
using ServiceLayerCommon.Shell;
using ServiceLayerCommon.Thread;
using ServiceLayerCommon.Transform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Unity;
using Unity.Lifetime;

namespace TCM.Web.API.Core.UnityConfigurations
{
    public class UnityConfigureCommon : IUnityConfigure
    {
        public IUnityContainer Init(IUnityContainer cnt)
        {            
            //cnt.RegisterType<CommonCore.Tcm.Common.Tcm.Logger.ILogger, TeLog4Net>(new ContainerControlledLifetimeManager());
           
            
            return cnt;
        }

        public string Environment
        {
            get { return "Common"; }
        }
    }
}
