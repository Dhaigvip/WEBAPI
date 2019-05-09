using Unity;
using CommonCore.Tcm.Common.Tcm.Logger;
using CommonCore.Tcm.Common.UnityContainer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using TCM.Web.API.Core.Domain;

namespace TCM.Web.API.Controllers
{
    [AllowAnonymous]
    [Route("api/[controller]")]
    [ApiController]
    public class JslogController : BaseController
    {

        private ILogger _logger;

        public JslogController(ILogger logger)
        {
            _logger = logger;
        }
        public void Post(JObject logMessage)
        {

            var logItem = new { user = "", url = "", message = "", type = "" };
            var logObj = JsonConvert.DeserializeAnonymousType(logMessage.ToString(), logItem);


            var logstring = string.Format("{0}, url{1}, {2}", User.Identity.Name, logObj.url, logObj.message);


            switch ((string)logObj.type)
            {
                case "error":
                    _logger.Log(logstring, "error", SeverityType.Error);

                    break;
                default:
                    _logger.Information(logstring);
                    break;
            }
        }
    }
}
