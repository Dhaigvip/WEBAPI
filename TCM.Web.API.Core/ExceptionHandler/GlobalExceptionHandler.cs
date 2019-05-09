using Unity;
using CommonCore.Tcm.Common.Tcm.Logger;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using TCM.Web.API.Core.Domain;
using CommonCore.Tcm.Common.UnityContainer;
using Newtonsoft.Json;

namespace TCM.Web.API.Core.ExceptionHandler
{
    public class GlobalExceptionHandler
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;
        public GlobalExceptionHandler(RequestDelegate next, ILogger logger)
        {
            _logger = logger;
            //_logger = UnityHelper.Container.Resolve<ILogger>();
            _next = next;
        }
        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                _logger.Exception(GetType(), ex);
                await HandleExceptionAsync(httpContext, ex);
            }
        }
        private Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

            var error = new Result<string>
            {
                Data = exception.Message,
                Success = false,
                ErrorList = new List<Error>
                {
                    new Error()
                    {
                        ErrorCode = context.Response.StatusCode.ToString(),
                        ErrorMessage = exception.Message
                    }
                }
            };
            var result = JsonConvert.SerializeObject(error);
            return context.Response.WriteAsync(result.ToString());
        }
    }
}
