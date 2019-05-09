using System;
using System.Threading.Tasks;
using TCM.Web.API.Core.Domain;
using TCM.Web.Business.Domain;
using TCM.Web.Business.Domain.Fund;


namespace TCM.Web.Business.Managers
{
    public class FundManager : BaseManager
    {
        public IResult<FundRepository> Find(FundRepository fundRepository)
        {
            throw new NotImplementedException();
        }

        public async Task<IResult<FundRepository>> FindAsync(FundRepository fundRepository)
        {
            ProxyXFMFund.FundRepositoryInput input = new ProxyXFMFund.FundRepositoryInput
            {
                FundRepository = AutoMapper.Mapper.Map<ProxyXFMFund.FundRepository>(fundRepository),

                InputContext = this.UpdateContext<ProxyXFMFund.Context>()
            };
            var result = await InvokeMethodAsync<Domain.FundRepository, ProxyXFMFund.WSFundClient>("Find", input);
            return result;
        }

        public IResult<FundOverviewRepository> OverviewFind(FundOverviewRepository inputDTO)
        {
            throw new NotImplementedException();
        }

        public async Task<IResult<FundOverviewRepository>> OverviewFindAsync(FundOverviewRepository inputDTO)
        {
            ProxyXFMFund.FundOverviewRepositoryInput input = new ProxyXFMFund.FundOverviewRepositoryInput();
            input.FundOverviewRepository = AutoMapper.Mapper.Map<ProxyXFMFund.FundOverviewRepository>(inputDTO);
            input.InputContext = this.UpdateContext<ProxyXFMFund.Context>();
            var result = await InvokeMethodAsync<Domain.Fund.FundOverviewRepository, ProxyXFMFund.WSFundClient>("OverviewFind", input);
            return result;
        }

        public IResult<FundSaveSet> Save(FundSaveSet inputDTO)
        {
            throw new NotImplementedException();
        }

        public async Task<IResult<FundSaveSet>> SaveAsync(FundSaveSet inputDTO)
        {
            ProxyXFMFund.FundSaveSetInput input = new ProxyXFMFund.FundSaveSetInput(); 
            input.FundSaveSet = AutoMapper.Mapper.Map<ProxyXFMFund.FundSaveSet>(inputDTO);
            input.InputContext = this.UpdateContext<ProxyXFMFund.Context>();
            var result = await InvokeMethodAsync<Domain.Fund.FundSaveSet, ProxyXFMFund.WSFundClient>("Save", input);
            return result;
        }
    }
}
