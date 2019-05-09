using System.Threading.Tasks;
using TCM.Web.API.Core.Domain;

namespace TCM.Web.API.Core.Managers
{
    public class OrderLightManager : BaseManager
    {

        public async Task<IResult<Business.ProxyLightOrder.AccountBalanceRepository>> AccountBalanceOverviewFindAsync(Business.ProxyLightOrder.AccountBalanceRepository inputDTO)
        {
            Business.ProxyLightOrder.AccountBalanceRepositoryInput input = new Business.ProxyLightOrder.AccountBalanceRepositoryInput
            {
                AccountBalanceRepository = inputDTO,
                InputContext = this.UpdateContext<Business.ProxyLightOrder.Context>()
            };
            var result = await InvokeMethodAsync<Business.ProxyLightOrder.AccountBalanceRepository, Business.ProxyLightOrder.WSOrderServiceClient>("AccountBalanceOverviewFind", input);
            return result;
        }



        public async Task<IResult<Business.ProxyLightOrder.OrderRepository>> OrderOverviewFindAsync(Business.ProxyLightOrder.OrderRepository inputDTO)
        {
            Business.ProxyLightOrder.OrderRepositoryInput input = new Business.ProxyLightOrder.OrderRepositoryInput
            {
                OrderRepository = inputDTO,
                InputContext = this.UpdateContext<Business.ProxyLightOrder.Context>()
            };
            var result = await InvokeMethodAsync<Business.ProxyLightOrder.OrderRepository, Business.ProxyLightOrder.WSOrderServiceClient>("OrderOverviewFind", input);
            return result;
        }
    }
}
