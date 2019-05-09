using System;
using System.Threading.Tasks;
using TCM.Web.API.Core.Domain;

namespace TCM.Web.Business.Managers
{
    public class CustomerManager : BaseManager
    {
        public async Task<IResult<ProxyLightCustomer.CustomerRepository>> FindAsync(ProxyLightCustomer.CustomerRepository inputDTO)
        {
            ProxyLightCustomer.CustomerRepositoryInput input = new ProxyLightCustomer.CustomerRepositoryInput();
            input.CustomerRepository = inputDTO;

            input.InputContext = this.UpdateContext<ProxyLightCustomer.Context>();
            var result = await InvokeMethodAsync<ProxyLightCustomer.CustomerRepository, ProxyLightCustomer.WSCustomerServiceClient>("Find", input);
            return result;
        }

        public async Task<IResult<ProxyLightCustomer.AccountRepository>> AccountFindAsync(ProxyLightCustomer.AccountRepository inputDTO)
        {
            ProxyLightCustomer.AccountRepositoryInput input = new ProxyLightCustomer.AccountRepositoryInput();
            input.AccountRepository = inputDTO;

            input.InputContext = this.UpdateContext<ProxyLightCustomer.Context>();
            var result = await InvokeMethodAsync<ProxyLightCustomer.AccountRepository, ProxyLightCustomer.WSCustomerServiceClient>("AccountFind", input);
            return result;
        }
    }
}
