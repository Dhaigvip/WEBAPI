using Unity;
using CommonCore.Tcm.Common.Tcm.Logger;
using CommonCore.Tcm.Common.UnityContainer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using TCM.Web.API.Core.Domain;
using TCM.Web.Business.Managers;

namespace TCM.Web.API.Controllers
{
    [Authorize()]
    [Route("api/[controller]")]
    [ApiController]
    public class UserSettingsController : BaseController
    {

        private readonly ILogger _logger;

        public UserSettingsController(ILogger logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromBody]TCMClientRequest obj)
        {
            IActionResult result = null;
            try
            {
                result =  HandleRequest(obj, new UserSettingsManager()).GetAwaiter().GetResult();
                return result;
            }
            catch (Exception ex)
            {
                _logger.Debug(GetType(), "Error getting user settings");
                _logger.Exception(GetType(), ex);
                return Ok(new TCMClientResponse { Success = false, Data = null });
            }
        }
        [HttpPost]

        public async Task<IActionResult> Post([FromBody]TCMClientRequest obj)
        {
            IActionResult result = null;
            try
            {
                result =  HandleRequest(obj, new UserSettingsManager()).GetAwaiter().GetResult();
                return result;
            }
            catch (Exception ex)
            {
                _logger.Debug(GetType(), "Error saving user settings");
                _logger.Exception(GetType(), ex);
                return Ok(new TCMClientResponse { Success = false, Data = null });
            }
        }

        [HttpPatch, HttpPut]

        public async Task<IActionResult> Put([FromBody]TCMClientRequest obj)
        {
            return await HandleRequest(obj, new UserSettingsManager());

        }
    }
}


