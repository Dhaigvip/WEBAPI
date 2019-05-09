using System;
using System.Threading.Tasks;
using TCM.Web.API.Core.Domain;
using TCM.Web.Business.Domain;
using TCM.Web.Business.Domain.Account;

namespace TCM.Web.Business.Managers
{
    public class AccountManager : BaseManager
    {

        public async Task<IResult<AccountRepository>> FindAsync(AccountRepository accountRepository)
        {

            ProxyXFMAccount.AccountRepositoryInput input = new ProxyXFMAccount.AccountRepositoryInput();
            input.AccountRepository = AutoMapper.Mapper.Map<ProxyXFMAccount.AccountRepository>(accountRepository);
            
            input.InputContext = this.UpdateContext<ProxyXFMAccount.Context>();
            var result = await InvokeMethodAsync<Domain.AccountRepository, ProxyXFMAccount.WSAccountClient>("Find", input);
            return result;
        }


        public async Task<IResult<ExternalAccount>> ExternalAccountSaveAsync(ExternalAccount inputDTO)
        {
            ProxyXFMAccount.ExternalAccountInput input = new ProxyXFMAccount.ExternalAccountInput();
            input.ExternalAccount = AutoMapper.Mapper.Map<ProxyXFMAccount.ExternalAccount>(inputDTO);
            input.InputContext = this.UpdateContext<ProxyXFMAccount.Context>();
            var result = await InvokeMethodAsync<Domain.ExternalAccount, ProxyXFMAccount.WSAccountClient>("ExternalAccountSave", input);
            return result;
        }

        public async Task<IResult<BalanceOverviewRepository>> BalanceOverviewFindAsync(BalanceOverviewRepository inputDTO)
        {
            ProxyXFMAccount.BalanceOverviewRepositoryInput input = new ProxyXFMAccount.BalanceOverviewRepositoryInput();
            input.BalanceOverviewRepository = AutoMapper.Mapper.Map<ProxyXFMAccount.BalanceOverviewRepository>(inputDTO);
            input.InputContext = this.UpdateContext<ProxyXFMAccount.Context>();
            var result = await InvokeMethodAsync<Domain.Account.BalanceOverviewRepository, ProxyXFMAccount.WSAccountClient>("BalanceOverviewFind", input);
            return result;
        }

        public async Task<IResult<ExternalAccountRepository>> ExternalAccountFindAsync(ExternalAccountRepository externalAccountRepository)
        {
            ProxyXFMAccount.ExternalAccountRepositoryInput input = new ProxyXFMAccount.ExternalAccountRepositoryInput();
            input.ExternalAccountRepository = AutoMapper.Mapper.Map<ProxyXFMAccount.ExternalAccountRepository>(externalAccountRepository);
            input.InputContext = this.UpdateContext<ProxyXFMAccount.Context>();
            var result = await InvokeMethodAsync<Domain.Account.ExternalAccountRepository, ProxyXFMAccount.WSAccountClient>("ExternalAccountFind", input);
            return result;
        }
    }
}
