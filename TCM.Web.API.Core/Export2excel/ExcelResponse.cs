using Unity;
using CommonCore.Tcm.Common.Tcm.Logger;
using CommonCore.Tcm.Common.UnityContainer;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using TCM.Web.API.Core.Domain;
using TCM.Web.API.Core.Helpers;


namespace TCM.Web.API.Core.Export2excel
{


    //public class T : IActionResult
    //{
    //    public Task ExecuteResultAsync(ActionContext context)
    //    {
    //        new HttpRequestMessage();
    //    }
    //}


  

    public class ExcelResponse
    {
        private TCMClientRequest obj;
        private BaseManager manager;
        private Func<TCMClientRequest, BaseManager, Task<dynamic>> GetData;
        ILogger _logger;
        public ExcelResponse(ILogger logger)
        {
            _logger = logger;
        }

        public ExcelResponse(Func<TCMClientRequest, BaseManager, Task<dynamic>> GetData, TCMClientRequest obj, BaseManager manager)
        {
            this.obj = obj;
            this.manager = manager;
            this.GetData = GetData;


        }
        private MemoryStream ExportToExcel(System.Collections.IList objList, List<ExportColumn> columnDetails)
        {
            ContentGenerator contentGenerator = new ContentGenerator() { ExportStrategy = new ExcelWorker() };
            return contentGenerator.GenerateExcel((System.Collections.IList)objList, new ExtendedGridProperties { ExportColumns = columnDetails });
        }

        public async Task<FileStreamResult> ExecuteResult()
        {

            var result = await GetData(obj, manager);
            dynamic temp = obj.Data;

            var t = result.GetType().GetProperty("Data").GetValue(result, null);
            var objlist = t.GetType().GetProperty(temp.ExportName.ToString()).GetValue(t) as IList;

            var cols = JsonConvert.DeserializeObject(temp.Columns.ToString(), typeof(List<ExportColumn>), SerializationSettings());
            MemoryStream stream = ExportToExcel(objlist, cols);

            string fileName = @"Download.xlsx";
            string fileType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
            stream.Position = 0;
            return new FileStreamResult(stream, fileType);




            //HttpResponseMessage response = new HttpResponseMessage()
            //{
            //    Content = new PushStreamContent(
            //   async (outputStream, httpContent, transportContext) =>
            //   {
            //       try
            //       {
            //           var result = await GetData(obj, manager);
            //           dynamic temp = obj.Data;

            //           var t = result.GetType().GetProperty("Data").GetValue(result, null);
            //           var objlist = t.GetType().GetProperty(temp.ExportName.ToString()).GetValue(t) as IList;

            //           var cols = JsonConvert.DeserializeObject(temp.Columns.ToString(), typeof(List<ExportColumn>), SerializationSettings());
            //           MemoryStream stream = ExportToExcel(objlist, cols);
            //           stream.WriteTo(outputStream);
            //           stream.Close();
            //       }
            //       catch (Exception ex)
            //       {
            //           _logger.Exception(GetType(), ex);
            //       }
            //       finally
            //       {
            //            // Close output stream as we are done
            //            outputStream.Close();
            //       }
            //   })

            //};

            //MediaTypeHeaderValue mediaType = new MediaTypeHeaderValue("application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");
            //response.Headers.Add("Content-Transfer-Encoding", "binary");
            //response.Content.Headers.ContentType = mediaType;
            //response.Content.Headers.ContentDisposition = new ContentDispositionHeaderValue("attachment")
            //{
            //    FileName = "Test.xls"
            //};
            //return response;
        }

        //public async Task<HttpResponseMessage> ExecuteAsync()
        //{
        //    HttpResponseMessage response = new HttpResponseMessage()
        //    {
        //        Content = new PushStreamContent(
        //        async (outputStream, httpContent, transportContext) =>
        //        {
        //            try
        //            {
        //                var result = await GetData(obj, manager);
        //                dynamic temp = obj.Data;

        //                var t = result.GetType().GetProperty("Data").GetValue(result, null);
        //                var objlist = t.GetType().GetProperty(temp.ExportName.ToString()).GetValue(t) as IList;

        //                var cols = JsonConvert.DeserializeObject(temp.Columns.ToString(), typeof(List<ExportColumn>), SerializationSettings());
        //                MemoryStream stream = ExportToExcel(objlist, cols);
        //                stream.WriteTo(outputStream);
        //                stream.Close();
        //            }
        //            catch (Exception ex)
        //            {
        //                _logger.Exception(GetType(), ex);
        //            }
        //            finally
        //            {
        //                // Close output stream as we are done
        //                outputStream.Close();
        //            }
        //        })

        //    };

        //    MediaTypeHeaderValue mediaType = new MediaTypeHeaderValue("application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");
        //    response.Headers.Add("Content-Transfer-Encoding", "binary");
        //    response.Content.Headers.ContentType = mediaType;
        //    response.Content.Headers.ContentDisposition = new ContentDispositionHeaderValue("attachment")
        //    {
        //        FileName = "Test.xls"
        //    };
        //    return response;
        //    //return new ActionResult<HttpResponseMessage>(response);
        //    //TO DO :
        //    //return null;
        //}
        private static JsonSerializerSettings SerializationSettings()
        {
            JsonSerializerSettings settings = new JsonSerializerSettings();
            settings.Converters.Add(new JsonDateConverter());
            settings.NullValueHandling = NullValueHandling.Ignore;
            settings.DateTimeZoneHandling = DateTimeZoneHandling.Local;
            settings.DateFormatHandling = DateFormatHandling.MicrosoftDateFormat;
            return settings;
        }
    }
}
