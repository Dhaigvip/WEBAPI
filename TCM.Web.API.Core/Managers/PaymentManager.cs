using System;
using System.Threading.Tasks;
using TCM.Web.API.Core.Domain;
using TCM.Web.Business.ProxyXFMPayment;

namespace TCM.Web.Business.Managers
{
    public class PaymentManager : BaseManager
    {
      

        public async Task<IResult<Domain.PaymentInformationRepository>> FindAsync(Domain.PaymentInformationRepository inputDTO)
        {
            ProxyXFMPayment.PaymentInformationRepositoryInput input = new ProxyXFMPayment.PaymentInformationRepositoryInput();
            input.PaymentInformationRepository = AutoMapper.Mapper.Map<ProxyXFMPayment.PaymentInformationRepository>(inputDTO);
            
            input.InputContext = this.UpdateContext<ProxyXFMPayment.Context>();
            var result = await InvokeMethodAsync<Domain.PaymentInformationRepository, ProxyXFMPayment.WSPaymentClient>("PaymentInformationFind", input);
            return result;
        }

        public IResult<Domain.PaymentInformation> PaymentInformationSave(Domain.PaymentInformation inputDTO)
        {
            throw new NotImplementedException();
        }

        public async Task<IResult<Domain.PaymentInformation>> PaymentInformationSaveAsync(Domain.PaymentInformation inputDTO)
        {
            ProxyXFMPayment.PaymentInformationInput input = new PaymentInformationInput();
            input.PaymentInformation = AutoMapper.Mapper.Map<ProxyXFMPayment.PaymentInformation>(inputDTO);
            input.InputContext = this.UpdateContext<ProxyXFMPayment.Context>();
            var result = await InvokeMethodAsync<Domain.PaymentInformation, ProxyXFMPayment.WSPaymentClient>("PaymentInformationSave", input);
            return result;
        }
    }
}
