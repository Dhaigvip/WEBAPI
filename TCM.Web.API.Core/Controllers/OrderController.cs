using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TCM.Web.API.Core.Domain;
using TCM.Web.Business.Managers;

namespace TCM.Web.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : BaseController
    {
        [HttpPost]

        public async Task<IActionResult> Post([FromBody]TCMClientRequest obj)
        {
            return  HandleRequest(obj, new OrderManager()).GetAwaiter().GetResult();

        }
    }
}
