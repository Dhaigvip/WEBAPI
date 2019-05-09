using CommonCore.Tcm.Common.Tcm.Logger;
using CommonCore.Tcm.Common.UnityContainer;
using Microsoft.AspNetCore.Http;
using Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http.Headers;

namespace TCM.Web.API.Core.Helpers
{
    public class Excelheaders
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;
        public Excelheaders(RequestDelegate next, ILogger logger)
        {
            _logger = logger;
            _next = next;
        }
        public async Task InvokeAsync(HttpContext httpContext)
        {

            if (httpContext.Request.Headers["Accept"] == "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet")
            {
                _logger.Log("Export to excel request", "info", SeverityType.Information);
            }
            await _next(httpContext);

            MediaTypeHeaderValue mediaType = new MediaTypeHeaderValue("application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");
            //httpContext.Response.Headers.Add("Content-Transfer-Encoding", "binary");
            //httpContext.Response.Content.Headers.ContentType = mediaType;
            //httpContext.Response.Content.Headers.ContentDisposition = new ContentDispositionHeaderValue("attachment")
            //{
            //    FileName = "Test.xls"
            //};
        }

    }
}
