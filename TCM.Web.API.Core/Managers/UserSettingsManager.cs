using System.Threading.Tasks;
using TCM.Web.API.Core.Domain;

using TCM.Web.Business.Domain.UserSettings;

namespace TCM.Web.Business.Managers
{
    public class UserSettingsManager : BaseManager
    {
        public async Task<IResult<PersisterDTO>> FindAsync(PersisterDTO repository)
        {
            ProxyXFMUserSettings.PersisterInput input = new ProxyXFMUserSettings.PersisterInput();
            input.PersisterDTO = AutoMapper.Mapper.Map<ProxyXFMUserSettings.Persister>(repository);

            input.InputContext = this.UpdateContext<ProxyXFMUserSettings.Context>();
            var result = await InvokeMethodAsync<Domain.UserSettings.PersisterDTO, ProxyXFMUserSettings.WSPersistSoapClient>("Find", input);
            return result;
        }

        public async Task<IResult<Domain.UserSettings.PersisterDTO>> UpdateAsync(PersisterDTO userSettings)
        {
            ProxyXFMUserSettings.PersisterInput input = new ProxyXFMUserSettings.PersisterInput();
            input.PersisterDTO = AutoMapper.Mapper.Map<ProxyXFMUserSettings.Persister>(userSettings);
            input.InputContext = this.UpdateContext<ProxyXFMUserSettings.Context>();
            var result = await InvokeMethodAsync<Domain.UserSettings.PersisterDTO, ProxyXFMUserSettings.WSPersistSoapClient>("AddOrUpdate", input);
            return result;
        }
    }
}
