using SıgnalRProject.DataAccess.UnıtOfWorks;
using SıgnalRProject.Entity.Entities;
using SıgnalRProject.Service.Services.Abstract;
using System.Linq.Expressions;

namespace SıgnalRProject.Service.Services.Concrete
{
    public class OrderDetailService : IOrderDetailService
    {
        private readonly IUnıtOfWork unıtOfWork;

        public OrderDetailService(IUnıtOfWork unıtOfWork)
        {
            this.unıtOfWork = unıtOfWork;
        }
        public async Task<OrderDetail> AddAsync(OrderDetail entity)
        {
            await unıtOfWork.GetRepository<OrderDetail>().AddAsync(entity);
            await unıtOfWork.SaveAsync();
            return entity;
        }

        public Task<bool> AnyAsync(Expression<Func<OrderDetail, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<int> CountAsync(Expression<Func<OrderDetail, bool>> predicate = null)
        {
            throw new NotImplementedException();
        }

        public async Task<OrderDetail> DeleteAsync(OrderDetail entity)
        {
            await unıtOfWork.GetRepository<OrderDetail>().DeleteAsync(entity);
            await unıtOfWork.SaveAsync();
            return entity;
        }

        public async Task<List<OrderDetail>> GetAllAsync(Expression<Func<OrderDetail, bool>> predicate = null, params Expression<Func<OrderDetail, object>>[] includeProperties)
        {
            return await unıtOfWork.GetRepository<OrderDetail>().GetAllAsync(predicate, includeProperties);
        }

        public async Task<List<OrderDetail>> GetAllAsync(params Expression<Func<OrderDetail, object>>[] includeProperties)
        {
            return await unıtOfWork.GetRepository<OrderDetail>().GetAllAsync( includeProperties);
        }

        public async Task<OrderDetail> GetAsync(Expression<Func<OrderDetail, bool>> predicate, params Expression<Func<OrderDetail, object>>[] includeProperties)
        {
            return await unıtOfWork.GetRepository<OrderDetail>().GetAsync(predicate, includeProperties);
        }

        public async Task<OrderDetail> GetAsync(params Expression<Func<OrderDetail, object>>[] includeProperties)
        {
            return await unıtOfWork.GetRepository<OrderDetail>().GetAsync(includeProperties);
        }

        public async Task<OrderDetail> GetByGuidAsync(Guid id)
        {
            return await unıtOfWork.GetRepository<OrderDetail>().GetByGuidAsync(id);
        }

        public async Task<OrderDetail> GetByIDAsync(int id)
        {
            return await unıtOfWork.GetRepository<OrderDetail>().GetByIDAsync(id);
        }

        public async Task<OrderDetail> UpdateAsync(OrderDetail entity)
        {
            await unıtOfWork.GetRepository<OrderDetail>().UpdateAsync(entity);
            await unıtOfWork.SaveAsync();
            return entity;
        }
    }
}
