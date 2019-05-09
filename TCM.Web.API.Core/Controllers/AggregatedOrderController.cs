using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TCM.Web.API.Core.Domain;
using TCM.Web.Business.Managers;
using TCM.Web.Business.ProxyXFMAggregatedOrder;

namespace TCM.Web.API.Controllers
{
    [Authorize] 
    [Route("api/[controller]")]
    [ApiController]
    public class AggregatedOrderController : BaseController
    {

        [HttpPost]

        public  async Task<ActionResult> Post([FromBody]TCMClientRequest obj)
        {
            return HandleRequest(obj, new AggregatedOrderManager()).GetAwaiter().GetResult();
        }
    }
}
