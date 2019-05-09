using Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommonCore.Tcm.Common.Tcm.Logger;
using CommonCore.Tcm.Common.UnityContainer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using TCM.Web.API.Core.Helpers;

namespace TCM.Web.API.Core.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        private readonly ILogger _logger;
        private IConfiguration _configuration;
        private string testEnv;

        public ValuesController(IConfiguration configuration, ILogger logger)
        {
            _logger = logger;
            _configuration = configuration;

            var appSettingsSection = _configuration.GetSection("AppSettings");


            // configure jwt authentication
            var appSettings = appSettingsSection.Get<AppSettings>();
            testEnv = appSettings.Environment;
        }
       

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
                 
            return new string[] { "value1", "value2", testEnv };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
            // For more information on protecting this API from Cross Site Request Forgery (CSRF) attacks, see https://go.microsoft.com/fwlink/?LinkID=717803
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            // For more information on protecting this API from Cross Site Request Forgery (CSRF) attacks, see https://go.microsoft.com/fwlink/?LinkID=717803
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            // For more information on protecting this API from Cross Site Request Forgery (CSRF) attacks, see https://go.microsoft.com/fwlink/?LinkID=717803
        }
    }
}
