using System;
using System.Threading.Tasks;
using TCM.Web.API.Core.Domain;
using TCM.Web.Business.Domain;
using TCM.Web.Business.Domain.Order;

namespace TCM.Web.Business.Managers
{
    public class OrderManager : BaseManager
    {


        public async Task<IResult<OrderRepository>> FindAsync(OrderRepository orderRepository)
        {
            ProxyXFMOrder.OrderRepositoryInput input = new ProxyXFMOrder.OrderRepositoryInput();
            input.OrderRepository = AutoMapper.Mapper.Map<ProxyXFMOrder.OrderRepository>(orderRepository);

            input.InputContext = this.UpdateContext<ProxyXFMOrder.Context>();
            var result = await InvokeMethodAsync<Domain.OrderRepository, ProxyXFMOrder.WSOrderClient>("Find", input);
            return result;
        }

        public IResult<Order> SaveRedemption(Order inputDTO)
        {
            throw new NotImplementedException();
        }

        public async Task<IResult<Order>> SaveRedemptionAsync(Order inputDTO)
        {
            ProxyXFMOrder.OrderInput input = new ProxyXFMOrder.OrderInput();
            input.Order = AutoMapper.Mapper.Map<ProxyXFMOrder.Order>(inputDTO);
            input.InputContext = this.UpdateContext<ProxyXFMOrder.Context>();
            var result = await InvokeMethodAsync<Domain.Order.Order, ProxyXFMOrder.WSOrderClient>("SaveRedemption", input);
            return result;
        }

        public async Task<IResult<Order>> SaveUnitAdjustmentAsync(Order inputDTO)
        {
            ProxyXFMOrder.OrderInput input = new ProxyXFMOrder.OrderInput();
            input.Order = AutoMapper.Mapper.Map<ProxyXFMOrder.Order>(inputDTO);
            input.InputContext = this.UpdateContext<ProxyXFMOrder.Context>();
            var result = await InvokeMethodAsync<Domain.Order.Order, ProxyXFMOrder.WSOrderClient>("SaveUnitAdjustment", input);
            return result;
        }



        public async Task<IResult<Order>> SaveSubscriptionAsync(Order inputDTO)
        {
            ProxyXFMOrder.OrderInput input = new ProxyXFMOrder.OrderInput();
            input.Order = AutoMapper.Mapper.Map<ProxyXFMOrder.Order>(inputDTO);
            input.InputContext = this.UpdateContext<ProxyXFMOrder.Context>();
            var result = await InvokeMethodAsync<Domain.Order.Order, ProxyXFMOrder.WSOrderClient>("SaveSubscription", input);
            return result;
        }

    }
}
