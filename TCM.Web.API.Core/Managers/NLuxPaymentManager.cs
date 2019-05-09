using System.Threading.Tasks;
using TCM.Web.API.Core.Domain;
using TCM.Web.Business.ProxyNLuxPayment;

namespace TCM.Web.Business.Managers
{
    public class NLuxPaymentManager : BaseManager
    {
        #region HolderCashAccount
        public async Task<IResult<HolderCashAccountRepository>> HolderCashAccountFind(HolderCashAccountRepository inputDTO)
        {
            ProxyNLuxPayment.HolderCashAccountRepositoryInput input = new ProxyNLuxPayment.HolderCashAccountRepositoryInput
            {
                HolderCashAccountRepository = AutoMapper.Mapper.Map<ProxyNLuxPayment.HolderCashAccountRepository>(inputDTO),
                InputContext = this.UpdateContext<ProxyNLuxPayment.Context>()
            };
            var result = await InvokeMethodAsync<HolderCashAccountRepository, ProxyNLuxPayment.WSPaymentClient>("HolderCashAccountFind", input);
            return result;
        }
        public async Task<IResult<HolderCashAccount>> HolderCashAccountDelete(HolderCashAccount inputDTO)
        {
            ProxyNLuxPayment.HolderCashAccountInput input = new ProxyNLuxPayment.HolderCashAccountInput
            {
                HolderCashAccount = AutoMapper.Mapper.Map<ProxyNLuxPayment.HolderCashAccount>(inputDTO),
                InputContext = this.UpdateContext<ProxyNLuxPayment.Context>()
            };
            var result = await InvokeMethodAsync<HolderCashAccount, ProxyNLuxPayment.WSPaymentClient>("HolderCashAccountDelete", input);
            return result;
        }
        public async Task<IResult<HolderCashAccount>> HolderCashAccountSave(HolderCashAccount inputDTO)
        {
            ProxyNLuxPayment.HolderCashAccountInput input = new ProxyNLuxPayment.HolderCashAccountInput
            {
                HolderCashAccount = AutoMapper.Mapper.Map<ProxyNLuxPayment.HolderCashAccount>(inputDTO),
                InputContext = this.UpdateContext<ProxyNLuxPayment.Context>()
            };
            var result = await InvokeMethodAsync<HolderCashAccount, ProxyNLuxPayment.WSPaymentClient>("HolderCashAccountSave", input);
            return result;
        }
        #endregion HolderCashAccount

        #region Branch
        public async Task<IResult<Branch>> BranchSave(Branch inputDTO)
        {
            ProxyNLuxPayment.BranchInput input = new ProxyNLuxPayment.BranchInput
            {
                Branch = AutoMapper.Mapper.Map<ProxyNLuxPayment.Branch>(inputDTO),
                InputContext = this.UpdateContext<ProxyNLuxPayment.Context>()
            };
            var result = await InvokeMethodAsync<Branch, ProxyNLuxPayment.WSPaymentClient>("BranchSave", input);
            return result;
        }

        public async Task<IResult<BranchRepository>> BranchFind(BranchRepository inputDTO)
        {
            ProxyNLuxPayment.BranchRepositoryInput input = new ProxyNLuxPayment.BranchRepositoryInput
            {
                BranchRepository = inputDTO,
                InputContext = this.UpdateContext<ProxyNLuxPayment.Context>()
            };
            var result = await InvokeMethodAsync<BranchRepository, ProxyNLuxPayment.WSPaymentClient>("BranchFind", input);
            return result;
        }
        #endregion Branch

        #region Bank
        public async Task<IResult<Bank>> BankSave(Bank inputDTO)
        {
            ProxyNLuxPayment.BankInput input = new ProxyNLuxPayment.BankInput
            {
                Bank = inputDTO,
                InputContext = this.UpdateContext<ProxyNLuxPayment.Context>()
            };
            var result = await InvokeMethodAsync<Bank, ProxyNLuxPayment.WSPaymentClient>("BankSave", input);
            return result;
        }
        public async Task<IResult<BankRepository>> BankFind(BankRepository inputDTO)
        {
            ProxyNLuxPayment.BankRepositoryInput input = new ProxyNLuxPayment.BankRepositoryInput
            {
                BankRepository = inputDTO,
                InputContext = this.UpdateContext<ProxyNLuxPayment.Context>()
            };
            var result = await InvokeMethodAsync<BankRepository, ProxyNLuxPayment.WSPaymentClient>("BankFind", input);
            return result;
        }
        #endregion Bank

        #region BIC
        public async Task<IResult<BIC>> BICSave(BIC inputDTO)
        {
            ProxyNLuxPayment.BICInput input = new ProxyNLuxPayment.BICInput
            {
                BIC = inputDTO,
                InputContext = this.UpdateContext<ProxyNLuxPayment.Context>()
            };
            var result = await InvokeMethodAsync<BIC, ProxyNLuxPayment.WSPaymentClient>("BICSave", input);
            return result;
        }

        public async Task<IResult<BICRepository>> BICFind(BICRepository inputDTO)
        {
            ProxyNLuxPayment.BICRepositoryInput input = new ProxyNLuxPayment.BICRepositoryInput
            {
                BICRepository = inputDTO,
                InputContext = this.UpdateContext<ProxyNLuxPayment.Context>()
            };
            var result = await InvokeMethodAsync<BICRepository, ProxyNLuxPayment.WSPaymentClient>("BICFind", input);
            return result;
        }
        #endregion BIC

        #region ExternalOwner
        public async Task<IResult<ExternalHolderCashAccountOwnerRepository>> ExternalHolderCashAccountOwnerGetByHolder(ExternalHolderCashAccountOwnerRepository inputDTO)
        {
            ProxyNLuxPayment.ExternalHolderCashAccountOwnerRepositoryInput input = new ProxyNLuxPayment.ExternalHolderCashAccountOwnerRepositoryInput
            {
                ExternalHolderCashAccountOwnerRepository = inputDTO,
                InputContext = this.UpdateContext<ProxyNLuxPayment.Context>()
            };
            var result = await InvokeMethodAsync<ExternalHolderCashAccountOwnerRepository, ProxyNLuxPayment.WSPaymentClient>("ExternalHolderCashAccountOwnerGetByHolder", input);
            return result;
        }

        public async Task<IResult<ExternalHolderCashAccountOwner>> ExternalHolderCashAccountOwnerSave(ExternalHolderCashAccountOwner inputDTO)
        {
            ProxyNLuxPayment.ExternalHolderCashAccountOwnerInput input = new ProxyNLuxPayment.ExternalHolderCashAccountOwnerInput
            {
                ExternalHolderCashAccountOwner = inputDTO,
                InputContext = this.UpdateContext<ProxyNLuxPayment.Context>()
            };
            var result = await InvokeMethodAsync<ExternalHolderCashAccountOwner, ProxyNLuxPayment.WSPaymentClient>("ExternalHolderCashAccountOwnerSave", input);
            return result;
        }
        #endregion ExternalOwner

        #region Overrider restrictions

        public async Task<IResult<RestrictedUmbrellaRepository>> RestrictedUmbrellaFind(RestrictedUmbrellaRepository inputDTO)
        {
            ProxyNLuxPayment.RestrictedUmbrellaRepositoryInput input = new ProxyNLuxPayment.RestrictedUmbrellaRepositoryInput
            {
                RestrictedUmbrellaRepository = inputDTO,
                InputContext = this.UpdateContext<ProxyNLuxPayment.Context>()
            };

            var result = await InvokeMethodAsync<RestrictedUmbrellaRepository, ProxyNLuxPayment.WSPaymentClient>("RestrictedUmbrellaFind", input);
            return result;
        }

        public async Task<IResult<RestrictedShareClassRepository>> RestrictedShareClassFind(RestrictedShareClassRepository inputDTO)
        {
            ProxyNLuxPayment.RestrictedShareClassRepositoryInput input = new ProxyNLuxPayment.RestrictedShareClassRepositoryInput
            {
                RestrictedShareClassRepository = inputDTO,
                InputContext = this.UpdateContext<ProxyNLuxPayment.Context>()
            };

            var result = await InvokeMethodAsync<RestrictedShareClassRepository, ProxyNLuxPayment.WSPaymentClient>("RestrictedShareClassFind", input);
            return result;
        }

        public async Task<IResult<RestrictedShareClassTypeRepository>> RestrictedShareClassTypeFind(RestrictedShareClassTypeRepository inputDTO)
        {
            ProxyNLuxPayment.RestrictedShareClassTypeRepositoryInput input = new ProxyNLuxPayment.RestrictedShareClassTypeRepositoryInput
            {
                RestrictedShareClassTypeRepository = inputDTO,
                InputContext = this.UpdateContext<ProxyNLuxPayment.Context>()
            };

            var result = await InvokeMethodAsync<RestrictedShareClassTypeRepository, ProxyNLuxPayment.WSPaymentClient>("RestrictedShareClassTypeFind", input);
            return result;
        }

        public async Task<IResult<OverrideRestrictedUmbrellaRepository>> OverrideRestrictedUmbrellaFind(OverrideRestrictedUmbrellaRepository inputDTO)
        {
            ProxyNLuxPayment.OverrideRestrictedUmbrellaRepositoryInput input = new ProxyNLuxPayment.OverrideRestrictedUmbrellaRepositoryInput
            {
                OverrideRestrictedUmbrellaRepository = inputDTO,
                InputContext = this.UpdateContext<ProxyNLuxPayment.Context>()
            };

            var result = await InvokeMethodAsync<OverrideRestrictedUmbrellaRepository, ProxyNLuxPayment.WSPaymentClient>("OverrideRestrictedUmbrellaFind", input);
            return result;
        }

        public async Task<IResult<OverrideRestrictedShareClassRepository>> OverrideRestrictedShareClassFind(OverrideRestrictedShareClassRepository inputDTO)
        {
            ProxyNLuxPayment.OverrideRestrictedShareClassRepositoryInput input = new ProxyNLuxPayment.OverrideRestrictedShareClassRepositoryInput
            {
                OverrideRestrictedShareClassRepository = inputDTO,
                InputContext = this.UpdateContext<ProxyNLuxPayment.Context>()
            };

            var result = await InvokeMethodAsync<OverrideRestrictedShareClassRepository, ProxyNLuxPayment.WSPaymentClient>("OverrideRestrictedShareClassFind", input);
            return result;
        }

        public async Task<IResult<OverrideRestrictedShareClassTypeRepository>> OverrideRestrictedShareClassTypeFind(OverrideRestrictedShareClassTypeRepository inputDTO)
        {
            ProxyNLuxPayment.OverrideRestrictedShareClassTypeRepositoryInput input = new ProxyNLuxPayment.OverrideRestrictedShareClassTypeRepositoryInput
            {
                OverrideRestrictedShareClassTypeRepository = inputDTO,
                InputContext = this.UpdateContext<ProxyNLuxPayment.Context>()
            };

            var result = await InvokeMethodAsync<OverrideRestrictedShareClassTypeRepository, ProxyNLuxPayment.WSPaymentClient>("OverrideRestrictedShareClassTypeFind", input);
            return result;
        }

        public async Task<IResult<OverrideRestriction>> OverrideRestrictionSave(OverrideRestriction inputDTO)
        {
            ProxyNLuxPayment.OverrideRestrictionInput input = new ProxyNLuxPayment.OverrideRestrictionInput
            {
                OverrideRestriction = inputDTO,
                InputContext = this.UpdateContext<ProxyNLuxPayment.Context>()
            };
            var result = await InvokeMethodAsync<OverrideRestriction, ProxyNLuxPayment.WSPaymentClient>("OverrideRestrictionSave", input);
            return result;
        }

        #endregion
    }
}
