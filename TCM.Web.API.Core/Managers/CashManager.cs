
using System.Threading.Tasks;
using TCM.Web.API.Core.Domain;
using TCM.Web.Business.ProxyCash;

namespace TCM.Web.Business.Managers
{
  public class CashManager : BaseManager
  {
    public async Task<IResult<HolderCashBalanceRepository>> HolderCashBalanceOverviewAsync(HolderCashBalanceRepository holderCashBalanceRepository)
    {
      HolderCashBalanceRepositoryInput input = new HolderCashBalanceRepositoryInput
      {
        HolderCashBalanceRepository = holderCashBalanceRepository,
        InputContext = this.UpdateContext<ProxyCash.Context>()
      };
      var result = await InvokeMethodAsync<HolderCashBalanceRepository, ProxyCash.WSCashClient>("HolderCashBalanceOverview", input);
      return result;
      throw new System.NotImplementedException();
    }

    public async Task<IResult<HolderCashTransactionRepository>> HolderCashTransactionOverviewAsync(HolderCashTransactionRepository holderCashTransactionRepository)
    {
      holderCashTransactionRepository.CriteriaType = "809";
      HolderCashTransactionRepositoryInput input = new HolderCashTransactionRepositoryInput
      {
        HolderCashTransactionRepository = holderCashTransactionRepository, 
        InputContext = this.UpdateContext<ProxyCash.Context>()        
      };
      var result = await InvokeMethodAsync<HolderCashTransactionRepository, ProxyCash.WSCashClient>("HolderCashTransactionOverview", input);
      return result;
      throw new System.NotImplementedException();
    }
    
  }
}
