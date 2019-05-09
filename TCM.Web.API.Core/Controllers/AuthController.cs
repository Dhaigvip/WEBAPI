
using CommonCore.Tcm.Common.Tcm.Logger;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;
using TCM.Web.API.Core.Authentication;
using TCM.Web.API.Core.Domain;
using TCM.Web.API.Core.Helpers;
using Unity;

namespace TCM.Web.API.Controllers
{

    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class AuthController : BaseController
    {

        private ILogger _logger;
        private IConfiguration _configuration;
        private AppSettings appSettings;
        IAuthenticate _authenticate;

        public AuthController(IConfiguration configuration, IAuthenticate authenticate, ILogger logger)
        {
            //_logger = UnityHelper.Container.Resolve<ILogger>();
            _logger = logger;
            _configuration = configuration;
            var appSettingsSection = _configuration.GetSection("AppSettings");
            appSettings = appSettingsSection.Get<AppSettings>();
            _authenticate = authenticate;
        }


        [HttpPost("Pre")]

        public async Task<IActionResult> Get()
        {
            var t = new TokenProvider();
            string token = t.CreateToken("Admin", "www.tieto.com", appSettings.Secret, null);

            var result = new TCMClientResponse
            {
                Data = token,
                Success = true
            };
            return Ok(result);
        }

        [HttpPost("External")]

        public async Task<IActionResult> AutheticateWithExternalIdProvider([FromBody]TCMClientRequest request)
        {
            dynamic inputData = request.Data;
            UserCredentials userCredentials = JsonConvert.DeserializeObject(inputData.ToString(), typeof(UserCredentials));
            if (userCredentials == null)
            {
                _logger.Debug(GetType(), "UserCredentials are null");
                throw new UnauthorizedAccessException();
            }
            if (userCredentials.UserName == null)
            {
                _logger.Debug(GetType(), "Username is null");
                throw new UnauthorizedAccessException();
            }
            if (userCredentials.Password == null)
            {
                _logger.Debug(GetType(), "Password is null");
                throw new UnauthorizedAccessException();
            }
            bool isAuthenticated = _authenticate.Authenticate(userCredentials);
            var result = CreateUserResponse(userCredentials.UserName, isAuthenticated,new List<string>());
            return Ok(result);
        }


        [HttpPost("Win")]
        [AllowAnonymous]
        public async Task<IActionResult> Post([FromBody]TCMClientRequest request)
        {
            if (request == null || request.MetaData == null) return null;
            return Ok(await GetContext());
        }

        private async Task<TCMClientResponse> GetContext()
        {
            if (User == null)
            {
                _logger.Debug(GetType(), "User is null");
                throw new UnauthorizedAccessException();
            }
            _logger.Debug(GetType(), $"User   {User}");

            if (User.Identity == null)
            {
                _logger.Debug(GetType(), "User.Identity is null");
                throw new UnauthorizedAccessException();
            }
            if (string.IsNullOrEmpty(User.Identity.Name))
            {
                _logger.Debug(GetType(), "User.Identity.Name is null");
                throw new UnauthorizedAccessException();
            }


            if ((!(User.Identity is WindowsIdentity identity)) || !identity.IsAuthenticated)
            {
                _logger.Debug(GetType(), "Thread.CurrentPrincipal is null");
                throw new UnauthorizedAccessException();
            }
            List<string> roleList = new List<string>();

            try
            {
                var groupNames = from id in identity.Groups
                                 select id.Translate(typeof(NTAccount)).Value;
                roleList = groupNames.ToList();
            }
            catch (Exception ex)
            {

                _logger.Exception(GetType(), ex);
            }

            return CreateUserResponse(User.Identity.Name, User.Identity.IsAuthenticated, roleList);
        }

        private TCMClientResponse CreateUserResponse(string username, bool isAutheticated, List<string> roleList)
        {
            var t = new TokenProvider();
            string token = t.CreateToken(username, "www.tieto.com", appSettings.Secret, roleList);

            var context = new ClientContext
            {
                Context = new Context
                {
                    RegUser = username,
                    ExtUser = username,
                    ExtChannelId = appSettings.ExtChannelId,
                    ExtId = appSettings.ExtId,
                    RegToken = 0,//(appSettings.RegToken != null) ? Convert.ToInt64(appSettings.RegToken) : 0,
                    RegInterface = appSettings.RegInterface,
                    LanguageId = appSettings.LanguageId
                },
                Token = token,
                //Roles = roleList.ToList(),
                IsAutheticated = isAutheticated
            };

            _logger.Debug(GetType(), JsonConvert.SerializeObject(context));

            var result = new TCMClientResponse
            {
                Data = context,
                Success = true
            };

            return result;
        }
    }
}
