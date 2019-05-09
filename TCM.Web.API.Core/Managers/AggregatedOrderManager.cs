using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCM.Web.API.Core.Domain;
using TCM.Web.Business.Domain;
using TCM.Web.Business.Domain.AggregatedOrder;


namespace TCM.Web.Business.Managers
{
    public class AggregatedOrderManager : BaseManager
    {
    
        public async Task<IResult<AggregatedOrderDeleteSet>> DeleteAsync(AggregatedOrderDeleteSet inputDTO)
        {
            ProxyXFMAggregatedOrder.AggregatedOrderDeleteSetInput input = new ProxyXFMAggregatedOrder.AggregatedOrderDeleteSetInput();
            input.AggregatedOrderDeleteSet = AutoMapper.Mapper.Map<ProxyXFMAggregatedOrder.AggregatedOrderDeleteSet>(inputDTO);
            
            input.InputContext = this.UpdateContext<ProxyXFMAggregatedOrder.Context>();
            var result = await InvokeMethodAsync<Domain.AggregatedOrder.AggregatedOrderDeleteSet, ProxyXFMAggregatedOrder.WSAggregatedOrderClient>("Delete", input);
            return result;
        }


        public async Task<IResult<AggregatedOrderRepository>> FindAsync(AggregatedOrderRepository aggregatedOrderRepository)
        {

            ProxyXFMAggregatedOrder.AggregatedOrderRepositoryInput input = new ProxyXFMAggregatedOrder.AggregatedOrderRepositoryInput();
            input.AggregatedOrderRepository = AutoMapper.Mapper.Map<ProxyXFMAggregatedOrder.AggregatedOrderRepository>(aggregatedOrderRepository);
            input.InputContext = this.UpdateContext<ProxyXFMAggregatedOrder.Context>();
            var result = await InvokeMethodAsync<Domain.AggregatedOrderRepository, ProxyXFMAggregatedOrder.WSAggregatedOrderClient>("Find", input);
            return result;
        }

        public async Task<IResult<AggregatedOrderUpdateSet>> UpdateAsync(AggregatedOrderUpdateSet inputDTO)
        {
            ProxyXFMAggregatedOrder.AggregatedOrderUpdateSetInput input = new ProxyXFMAggregatedOrder.AggregatedOrderUpdateSetInput();
            input.AggregatedOrderUpdateSet = AutoMapper.Mapper.Map<ProxyXFMAggregatedOrder.AggregatedOrderUpdateSet>(inputDTO);
            input.InputContext = this.UpdateContext<ProxyXFMAggregatedOrder.Context>();
            var result = await InvokeMethodAsync<Domain.AggregatedOrderUpdateSet, ProxyXFMAggregatedOrder.WSAggregatedOrderClient>("Update", input);
            return result;
        }
    }
}
