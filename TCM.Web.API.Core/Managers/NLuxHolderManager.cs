using System.Threading.Tasks;
using TCM.Web.API.Core.Domain;
using TCM.Web.Business.ProxyNLuxHolder;

namespace TCM.Web.Business.Managers
{
    public class NLuxHolderManager : BaseManager
    {
        public async Task<IResult<Holder>> BeneficialOwnerSaveAsync(Holder inputDTO)
        {
            ProxyNLuxHolder.HolderInput input = new ProxyNLuxHolder.HolderInput
            {
                Holder = inputDTO,
                InputContext = this.UpdateContext<ProxyNLuxHolder.Context>()
            };
            var result = await InvokeMethodAsync<Holder, ProxyNLuxHolder.WSHolderClient>("BeneficialOwnerSave", input);
            return result;
        }


        public async Task<IResult<HolderRepository>> FindAsync(HolderRepository holderRepository)
        {
            ProxyNLuxHolder.HolderRepositoryInput input = new ProxyNLuxHolder.HolderRepositoryInput
            {

                HolderRepository = holderRepository,

                InputContext = this.UpdateContext<ProxyNLuxHolder.Context>()
            };
            var result = await InvokeMethodAsync<HolderRepository, ProxyNLuxHolder.WSHolderClient>("Find", input);
            return result;
        }
    }
}
