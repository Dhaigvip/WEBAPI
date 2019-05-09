using System.Threading.Tasks;
using TCM.Web.API.Core.Domain;
using TCM.Web.Business.ProxyCost;

namespace TCM.Web.Business.Managers
{
    public class CostManager : BaseManager
    {
        
        public async Task<IResult<AccountCostOverviewRepository>> AccountCostOverviewFindAsync(AccountCostOverviewRepository accountCostOverviewRepository)
        {
            AccountCostOverviewRepositoryInput input = new AccountCostOverviewRepositoryInput
            {
                AccountCostOverviewRepository = accountCostOverviewRepository,
                InputContext = this.UpdateContext<ProxyCost.Context>()
            };
            var result = await InvokeMethodAsync<AccountCostOverviewRepository, ProxyCost.WSCostClient>("AccountCostOverviewFind", input);
            return result;
        }

        public async Task<IResult<AccountOverviewRepository>> AccountOverviewFindAsync(AccountOverviewRepository inputDTO)
        {
            AccountOverviewRepositoryInput input = new AccountOverviewRepositoryInput
            {
                AccountOverviewRepository = inputDTO,
                InputContext = this.UpdateContext<ProxyCost.Context>()
            };
            var result = await InvokeMethodAsync<AccountOverviewRepository, ProxyCost.WSCostClient>("AccountOverviewFind", input);
            return result;
        }

        public async Task<IResult<CostEstimateRepository>> EstimateCostsAsync(CostEstimateRepository inputDTO)
        {
            CostEstimateRepositoryInput input = new CostEstimateRepositoryInput
            {
                CostEstimateRepository = inputDTO,
                InputContext = this.UpdateContext<ProxyCost.Context>()
            };
            var result = await InvokeMethodAsync<CostEstimateRepository, ProxyCost.WSCostClient>("EstimateCosts", input);
            return result;
        }

        public async Task<IResult<InstrumentCostOverviewRepository>> InstrumentCostOverviewFindAsync(InstrumentCostOverviewRepository inputDTO)
        {
            InstrumentCostOverviewRepositoryInput input = new InstrumentCostOverviewRepositoryInput
            {
                InstrumentCostOverviewRepository = inputDTO,
                InputContext = this.UpdateContext<ProxyCost.Context>()
            };
            var result = await InvokeMethodAsync<InstrumentCostOverviewRepository, ProxyCost.WSCostClient>("InstrumentCostOverviewFind", input);
            return result;
        }

        public async Task<IResult<InstrumentOverviewRepository>> InstrumentOverviewFindAsync(InstrumentOverviewRepository inputDTO)
        {
            InstrumentOverviewRepositoryInput input = new InstrumentOverviewRepositoryInput
            {
                InstrumentOverviewRepository = inputDTO,
                InputContext = this.UpdateContext<ProxyCost.Context>()
            };
            var result = await InvokeMethodAsync<InstrumentOverviewRepository, ProxyCost.WSCostClient>("InstrumentOverviewFind", input);
            return result;
        }

        public async Task<IResult<SebAccountCostDetailOverviewRepository>> SebAccountCostDetailOverviewFindAsync(SebAccountCostDetailOverviewRepository inputDTO)
        {
            SebAccountCostDetailOverviewRepositoryInput input = new SebAccountCostDetailOverviewRepositoryInput
            {
                SebAccountCostDetailOverviewRepository = inputDTO,
                InputContext = this.UpdateContext<ProxyCost.Context>()
            };
            var result = await InvokeMethodAsync<SebAccountCostDetailOverviewRepository, ProxyCost.WSCostClient>("SebAccountCostDetailOverviewFind", input);
            return result;
        }
    }
}
