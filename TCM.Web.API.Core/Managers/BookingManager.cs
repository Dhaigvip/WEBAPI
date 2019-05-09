
using System.Threading.Tasks;
using TCM.Web.API.Core.Domain;
using TCM.Web.Business.Domain.Booking;

namespace TCM.Web.Business.Managers
{
    public class BookingManager : BaseManager
    {
        public async Task<IResult<BookingOverviewRepository>> BookingOverviewFindAsync(BookingOverviewRepository inputDTO)
        {
            ProxyBooking.BookingOverviewRepositoryInput input = new ProxyBooking.BookingOverviewRepositoryInput();
            input.BookingOverviewRepository = AutoMapper.Mapper.Map<ProxyBooking.BookingOverviewRepository>(inputDTO);
            
            input.InputContext = this.UpdateContext<ProxyBooking.Context>();
            var result = await InvokeMethodAsync<Domain.Booking.BookingOverviewRepository, ProxyBooking.WSBookingClient>("BookingOverviewFind", input);
            return result;
        }
    }
}
