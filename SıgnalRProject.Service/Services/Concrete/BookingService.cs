using SıgnalRProject.DataAccess.UnıtOfWorks;
using SıgnalRProject.Dto.BookingDto;
using SıgnalRProject.Entity.Entities;
using SıgnalRProject.Service.Services.Abstract;
using System.Linq.Expressions;


namespace SıgnalRProject.Service.Services.Concrete
{
    public class BookingService : IBookingService
    {
        private readonly IUnıtOfWork unıtOfWork;

        public BookingService(IUnıtOfWork unıtOfWork)
        {
            this.unıtOfWork = unıtOfWork;
        }
        public async Task<Booking> AddAsync(Booking entity)
        {
            entity.Description = "Rezervasyon Alındı";
            await unıtOfWork.GetRepository<Booking>().AddAsync(entity);
            await unıtOfWork.SaveAsync();
            return entity;
        }

        public Task<bool> AnyAsync(Expression<Func<Booking, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public async Task BookingStatusApproved(int id)
        {
            var booking = await unıtOfWork.GetRepository<Booking>().GetByIDAsync(id);
            booking.Description = "Rezervasyon Yapıldı";
            await unıtOfWork.GetRepository<Booking>().UpdateAsync(booking);
            await unıtOfWork.SaveAsync();

        }

        public async Task BookingStatusCancelled(int id)
        {
            var booking = await unıtOfWork.GetRepository<Booking>().GetByIDAsync(id);
            booking.Description = "Rezervasyon İptal Edildi";
            await unıtOfWork.GetRepository<Booking>().UpdateAsync(booking);
            await unıtOfWork.SaveAsync();
        }

        public Task<int> CountAsync(Expression<Func<Booking, bool>> predicate = null)
        {
            throw new NotImplementedException();
        }

        public async Task<Booking> DeleteAsync(Booking entity)
        {
            await unıtOfWork.GetRepository<Booking>().AddAsync(entity);
            await unıtOfWork.SaveAsync();
            return entity;
        }

        public async Task<List<Booking>> GetAllAsync(Expression<Func<Booking, bool>> predicate = null, params Expression<Func<Booking, object>>[] includeProperties)
        {
            return await unıtOfWork.GetRepository<Booking>().GetAllAsync(predicate, includeProperties);
        }

        public async Task<List<Booking>> GetAllAsync(params Expression<Func<Booking, object>>[] includeProperties)
        {
            return await unıtOfWork.GetRepository<Booking>().GetAllAsync(includeProperties);
        }

        public async Task<Booking> GetAsync(Expression<Func<Booking, bool>> predicate, params Expression<Func<Booking, object>>[] includeProperties)
        {
            return await unıtOfWork.GetRepository<Booking>().GetAsync(predicate, includeProperties);
        }

        public async Task<Booking> GetAsync(params Expression<Func<Booking, object>>[] includeProperties)
        {
            return await unıtOfWork.GetRepository<Booking>().GetAsync(includeProperties);
        }

        public async Task<Booking> GetByGuidAsync(Guid id)
        {
            return await unıtOfWork.GetRepository<Booking>().GetByGuidAsync(id);
        }

        public async Task<Booking> GetByIDAsync(int id)
        {
            return await unıtOfWork.GetRepository<Booking>().GetByIDAsync(id);
        }

        public async Task<Booking> UpdateAsync(Booking entity)
        {
            await unıtOfWork.GetRepository<Booking>().UpdateAsync(entity);
            await unıtOfWork.SaveAsync();
            return entity;
        }
    }
}
