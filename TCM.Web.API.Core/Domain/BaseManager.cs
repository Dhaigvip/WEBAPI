using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.ServiceModel.Description;
using System.Threading;
using System.Threading.Tasks;
using TCM.Web.API.Core.Helpers;

namespace TCM.Web.API.Core.Domain
{


    public class BaseManager
    {
        List<Endpoint> _endpoints;
        public BaseManager()
        {
            _endpoints = Startup.Configuration.GetSection("Endpoints").Get<List<Endpoint>>();
        }

        public Context Context { get; set; }



        private IResult<T> PrepareResult<T>(IDisposable wsClient, object output)
        {
            IResult<T> result = new Result<T>();
            var outputSuccess = output.GetType().GetProperty("Success");
            if ((bool)outputSuccess.GetValue(output, null))
            {
                result.Success = true;
                var outputObject = output.GetType().GetProperty(typeof(T).Name);
                result.Data = AutoMapper.Mapper.Map<T>(outputObject.GetValue(output, null));
            }
            else
            {
                var outputErrorList = output.GetType().GetProperty("ErrorList");
                result.ErrorList = AutoMapper.Mapper.Map<List<Domain.Error>>(outputErrorList.GetValue(output, null));
            }

            var closeMethod = wsClient.GetType().GetMethod("Close");
            closeMethod.Invoke(wsClient, null);
            return result;
        }


        public T UpdateContext<T>()
        {
            Type objectType = this.Context.GetType();
            Type target = typeof(T);
            var x = Activator.CreateInstance(target, false);
            var z = from source in objectType.GetMembers().ToList()
                    where source.MemberType == MemberTypes.Property
                    select source;
            var d = from source in target.GetMembers().ToList()
                    where source.MemberType == MemberTypes.Property
                    select source;
            List<MemberInfo> members = d.Where(memberInfo => d.Select(c => c.Name)
               .ToList().Contains(memberInfo.Name)).ToList();
            PropertyInfo propertyInfo;
            object value;
            foreach (var memberInfo in members)
            {
                propertyInfo = typeof(T).GetProperty(memberInfo.Name);
                var prop = this.Context.GetType().GetProperty(memberInfo.Name);
                if (prop != null)
                {
                    value = prop.GetValue(this.Context, null);
                    propertyInfo.SetValue(x, value, null);
                }
            }
            return (T)x;
        }


        protected async Task<IResult<T>> InvokeMethodAsync<T, TN>(string method, dynamic input)
        {
            dynamic wsClient = null;
            try
            {
                wsClient = Activator.CreateInstance<TN>();
                wsClient = UpdateCustomURL(wsClient);
                // Call service layer method using reflection
                var mi = typeof(TN).GetMethod(method + "Async");
                var output = await (dynamic)mi.Invoke(wsClient, new[] { input });

                // Check status and create result object
                IResult<T> result = PrepareResult<T>(wsClient, output);
                return result;
            }
            catch (AggregateException ex)
            {
                var abortMethod = wsClient.GetType().GetMethod("Abort");
                abortMethod.Invoke(wsClient, null);
                throw ex.InnerException;
            }
            catch (Exception ex)
            {
                var abortMethod = wsClient.GetType().GetMethod("Abort");
                abortMethod.Invoke(wsClient, null);
                throw;
            }
        }

        private dynamic UpdateCustomURL(dynamic wsClient)
        {
            var key = wsClient.GetType().FullName;
            var url = _endpoints.Where(x => x.Name == key).FirstOrDefault().EndPointUrl;

            IEnumerator<PropertyInfo> listOfProps = ((TypeInfo)wsClient.GetType().BaseType).DeclaredProperties.GetEnumerator();
            while (listOfProps.MoveNext())
            {
                if (listOfProps.Current.Name == "Endpoint")
                {
                    var prop = listOfProps.Current;
                    ServiceEndpoint ep = prop.GetValue(wsClient);
                    ep.Address = new System.ServiceModel.EndpointAddress(url);
                    break;
                }
            }
            return wsClient;
        }
    }
}
