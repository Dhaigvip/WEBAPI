using CommonCore.Tcm.Common.Tcm.Logger;
using Unity;
using CommonCore.Tcm.Common.UnityContainer;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;
using TCM.Web.API.Core.Export2excel;
using TCM.Web.API.Core.Helpers;
using System.Net.Http.Headers;

namespace TCM.Web.API.Core.Domain
{
    public class BaseController : ControllerBase
    {


        private ILogger Logger;

        public BaseController()
        {
            Logger = UnityHelper.Container.Resolve<ILogger>();
        }


        protected async Task<ActionResult> HandleRequest(TCMClientRequest obj, BaseManager manager)
        {
            var logRequest = JsonConvert.SerializeObject(obj);
            Logger.Debug(GetType(), logRequest);

            try
            {
                //export or large data
                if (!string.IsNullOrEmpty(obj.MetaData.Command) && obj.MetaData.Command.ToLower() == "export")
                {
                    return await new ExcelResponse(this.GetData, obj, manager).ExecuteResult();
                }
                else
                {
                    dynamic result = await GetData(obj, manager);
                    return Ok(result);
                }
            }
            catch (Exception ex)
            {
                Logger.Exception(ex);
                return BadRequest();
            }
        }

        protected async Task<dynamic> GetData(TCMClientRequest obj, BaseManager manager)
        {
            if (obj.MetaData == null || string.IsNullOrEmpty(obj.MetaData.Action))
            {
                return null;
            }
            JsonSerializerSettings settings = SerializationSettings();
            manager.Context = obj.Context;

            dynamic inputData = obj.Data;
            dynamic temp = obj.Data;

            if (!string.IsNullOrEmpty(obj.MetaData.Command) && obj.MetaData.Command.ToLower() == "export")
            {
                inputData = temp.Repository;
            }

            var mi = manager.GetType().GetMethod(obj.MetaData.Action);
            Logger.Debug(GetType(), $"Calling method  {obj}");

            dynamic param = null;
            Type paramType = null;

            if (inputData != null)
            {
                paramType = mi.GetParameters()[0].ParameterType;
                param = JsonConvert.DeserializeObject(inputData.ToString(), paramType, settings);
            }
            try
            {
                dynamic result;

                if (param != null)
                    result = await (dynamic)mi.Invoke(manager, new[] { param });
                else
                    result = await (dynamic)mi.Invoke(manager, null);

                return result;
            }
            catch (Exception ex)
            {
                Logger.Exception(ex);
                throw;
            }
        }

        private static JsonSerializerSettings SerializationSettings()
        {
            JsonSerializerSettings settings = new JsonSerializerSettings();
            settings.Converters.Add(new JsonDateConverter());
            settings.NullValueHandling = NullValueHandling.Ignore;
            settings.DateTimeZoneHandling = DateTimeZoneHandling.Local;
            settings.DateFormatHandling = DateFormatHandling.MicrosoftDateFormat;
            return settings;
        }
    }
}
