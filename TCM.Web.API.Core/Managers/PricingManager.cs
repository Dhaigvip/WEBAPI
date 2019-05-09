using System;
using System.Threading.Tasks;
using TCM.Web.API.Core.Domain;
using TCM.Web.Business.ProxyXFMPricing;

namespace TCM.Web.Business.Managers
{
    public class PricingManager : BaseManager
    {
     

        public async Task<IResult<Domain.FundPriceRepository>> FundPriceFindAsync(Domain.FundPriceRepository inputDTO)
        {
            ProxyXFMPricing.FundPriceRepositoryInput input = new FundPriceRepositoryInput();  
            input.FundPriceRepository = AutoMapper.Mapper.Map<ProxyXFMPricing.FundPriceRepository>(inputDTO);
            //this.UpdateContext<ProxyXFMPricing.Context>(input);
            input.InputContext = this.UpdateContext<ProxyXFMPricing.Context>();
            var result = await InvokeMethodAsync<Domain.FundPriceRepository, ProxyXFMPricing.WSPricingClient>("FundPriceFind", input);
            return result;
        }

        public IResult<Domain.FundPriceSaveSet> FundPriceSave(Domain.FundPriceSaveSet inputDTO)
        {
            throw new NotImplementedException();
        }

        public async Task<IResult<Domain.FundPriceSaveSet>> FundPriceSaveAsync(Domain.FundPriceSaveSet inputDTO)
        {
            ProxyXFMPricing.FundPriceSaveSetInput input = new FundPriceSaveSetInput(); 
            input.FundPriceSaveSet = AutoMapper.Mapper.Map<ProxyXFMPricing.FundPriceSaveSet>(inputDTO);
            input.InputContext = this.UpdateContext<ProxyXFMPricing.Context>();
            var result = await InvokeMethodAsync<Domain.FundPriceSaveSet, ProxyXFMPricing.WSPricingClient>("FundPriceSave", input);
            return result;
        }


        public async Task<IResult<Domain.FxOrderRepository>> FxOrderFindAsync(Domain.FxOrderRepository inputDTO)
        {
            ProxyXFMPricing.FxOrderRepositoryInput input = new FxOrderRepositoryInput();
            input.FxOrderRepository = AutoMapper.Mapper.Map<ProxyXFMPricing.FxOrderRepository>(inputDTO);
            input.InputContext = this.UpdateContext<ProxyXFMPricing.Context>();
            var result = await InvokeMethodAsync<Domain.FxOrderRepository, ProxyXFMPricing.WSPricingClient>("FxOrderFind", input);
            return result;
        }


        public async Task<IResult<Domain.FxOrderUpdateSet>> FxOrderUpdateAsync(Domain.FxOrderUpdateSet inputDTO)
        {
            ProxyXFMPricing.FxOrderUpdateSetInput input = new FxOrderUpdateSetInput();
            input.FxOrderUpdateSet = AutoMapper.Mapper.Map<ProxyXFMPricing.FxOrderUpdateSet>(inputDTO);
            input.InputContext = this.UpdateContext<ProxyXFMPricing.Context>();
            var result = await InvokeMethodAsync<Domain.FxOrderUpdateSet, ProxyXFMPricing.WSPricingClient>("FxOrderUpdate", input);
            return result;
        }
    }
}
