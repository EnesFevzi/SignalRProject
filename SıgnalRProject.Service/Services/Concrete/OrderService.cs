using SıgnalRProject.DataAccess.UnıtOfWorks;
using SıgnalRProject.Entity.Entities;
using SıgnalRProject.Service.Services.Abstract;
using System.Linq.Expressions;

namespace SıgnalRProject.Service.Services.Concrete
{
    public class OrderService : IOrderService
    {
        private readonly IUnıtOfWork unıtOfWork;

        public OrderService(IUnıtOfWork unıtOfWork)
        {
            this.unıtOfWork = unıtOfWork;
        }
        public async Task AddAsync(Order entity)
        {
            await unıtOfWork.GetRepository<Order>().AddAsync(entity);
            await unıtOfWork.SaveAsync();
        }

        public Task<bool> AnyAsync(Expression<Func<Order, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<int> CountAsync(Expression<Func<Order, bool>> predicate = null)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(Order entity)
        {
            await unıtOfWork.GetRepository<Order>().DeleteAsync(entity);
            await unıtOfWork.SaveAsync();
        }

        public async Task<List<Order>> GetAllAsync(Expression<Func<Order, bool>> predicate = null, params Expression<Func<Order, object>>[] includeProperties)
        {
            return await unıtOfWork.GetRepository<Order>().GetAllAsync(predicate, includeProperties);
        }

        public async Task<List<Order>> GetAllAsync(params Expression<Func<Order, object>>[] includeProperties)
        {
            return await unıtOfWork.GetRepository<Order>().GetAllAsync(includeProperties);
        }

        public async Task<Order> GetAsync(Expression<Func<Order, bool>> predicate, params Expression<Func<Order, object>>[] includeProperties)
        {
            return await unıtOfWork.GetRepository<Order>().GetAsync(predicate, includeProperties);
        }

        public async Task<Order> GetAsync(params Expression<Func<Order, object>>[] includeProperties)
        {
            return await unıtOfWork.GetRepository<Order>().GetAsync(includeProperties);
        }

        public async Task<Order> GetByGuidAsync(Guid id)
        {
            return await unıtOfWork.GetRepository<Order>().GetByGuidAsync(id);
        }

        public async Task<Order> GetByIDAsync(int id)
        {
            return await unıtOfWork.GetRepository<Order>().GetByIDAsync(id);
        }

        public async Task UpdateAsync(Order entity)
        {
            await unıtOfWork.GetRepository<Order>().UpdateAsync(entity);
            await unıtOfWork.SaveAsync();
        }
    }
}
