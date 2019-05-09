using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TCM.Web.API.Core.Domain;
using TCM.Web.API.Core.Managers;

namespace TCM.Web.API.Core.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class OrderLightController : BaseController
    {
        [HttpPost]

        public async Task<IActionResult> Post([FromBody]TCMClientRequest obj)
        {
            return HandleRequest(obj, new OrderLightManager()).GetAwaiter().GetResult();

        }
    }
}
