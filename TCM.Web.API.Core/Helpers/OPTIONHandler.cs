using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TCM.Web.API.Core.Helpers
{

    public static class OPTION_HandlerExtension
    {
        public static IApplicationBuilder Handle_OPTIONS_Request(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<OPTIONHandler>();
        }
    }
    public class OPTIONHandler
    {
        private readonly RequestDelegate _next;
        public OPTIONHandler(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            BeginInvoke(context);
        }
        private async void BeginInvoke(HttpContext context)
        {



            if (context.Request.Method == "OPTIONS")
            {
                context.Response.Headers.Add("Access-Control-Allow-Origin", context.Request.Headers["origin"]);
                context.Response.Headers.Add("Access-Control-Allow-Headers", "Origin, Content-Type, X-Auth-Token, x-requested-with, Authorization");
                //context.Response.Headers.Add("Access-Control-expose-Headers", "AuthToken");
                context.Response.Headers.Add("Access-Control-Allow-Methods", "GET, POST, PATCH, PUT, DELETE, OPTIONS");
                context.Response.Headers.Add("Access-Control-Allow-Credentials", "true");
                context.Response.Headers.Add("Access-Control-Max-Age", "1728000");

                context.Response.StatusCode = 200;
            }
            else if (context.Request.Method != "OPTIONS" && !context.User.Identity.IsAuthenticated)
            {
                context.Response.StatusCode = 401;
                //context.Response.Headers.Add("WWW-Authenticate", "Basic");
                await context.Response.WriteAsync("Not Authenticted");
            }
            else
            {
                await _next.Invoke(context);
            }
            
        }
    }
}
