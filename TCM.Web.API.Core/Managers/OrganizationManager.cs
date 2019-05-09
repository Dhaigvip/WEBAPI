using System;
using System.Threading.Tasks;
using TCM.Web.API.Core.Domain;
using TCM.Web.Business.Domain;
using TCM.Web.Business.Domain.Organisation;

namespace TCM.Web.Business.Managers
{
    public class OrganizationManager : BaseManager
    {
      

        public async Task<IResult<OrganizationRepository>> FindAsync(OrganizationRepository organizationRepository)
        {
            ProxyXFMOrganization.OrganizationRepositoryInput input = new ProxyXFMOrganization.OrganizationRepositoryInput();
            input.OrganizationRepository = AutoMapper.Mapper.Map<ProxyXFMOrganization.OrganizationRepository>(organizationRepository);

            input.InputContext = this.UpdateContext<ProxyXFMOrganization.Context>();
            var result = await InvokeMethodAsync<Domain.OrganizationRepository, ProxyXFMOrganization.WSOrganizationClient>("Find", input);
            return result;
        }
        public async Task<IResult<OrganizationSaveSet>> SaveAsync(OrganizationSaveSet inputDTO)
        {
            ProxyXFMOrganization.OrganizationSaveSetInput input = new ProxyXFMOrganization.OrganizationSaveSetInput();
            input.OrganizationSaveSet = AutoMapper.Mapper.Map<ProxyXFMOrganization.OrganizationSaveSet>(inputDTO);
            input.InputContext = this.UpdateContext<ProxyXFMOrganization.Context>();
            var result = await InvokeMethodAsync<Domain.Organisation.OrganizationSaveSet, ProxyXFMOrganization.WSOrganizationClient>("Save", input);
            return result;
        }
    }
}
