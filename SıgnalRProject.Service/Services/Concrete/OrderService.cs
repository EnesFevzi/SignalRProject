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



        public async Task<Order> AddAsync(Order entity)
        {
            await unıtOfWork.GetRepository<Order>().AddAsync(entity);
            await unıtOfWork.SaveAsync();
            return entity;
        }

        public Task<bool> AnyAsync(Expression<Func<Order, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<int> CountAsync(Expression<Func<Order, bool>> predicate = null)
        {
            throw new NotImplementedException();
        }

        public async Task<Order> DeleteAsync(Order entity)
        {
            await unıtOfWork.GetRepository<Order>().DeleteAsync(entity);
            await unıtOfWork.SaveAsync();
            return entity;
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
        public async Task<int> ActiveOrderCount()
        {
            var order = await unıtOfWork.GetRepository<Order>().CountAsync(x => x.Description == "Müşteri Masada");
            return order;
        }
        public async Task<decimal> LastOrderPrice()
        {
            var orders = await unıtOfWork.GetRepository<Order>().GetAllAsync();
            var value = orders.OrderByDescending(x => x.OrderID).Take(1).Select(x => x.TotalPrice).FirstOrDefault();
            return value;
        }

        public async Task<decimal> TodayTotalPrice()
        {
            return 0;
        }

        public async Task<int> TotalOrderCount()
        {
            var order = await unıtOfWork.GetRepository<Order>().CountAsync();
            return order;
        }

        public async Task<Order> UpdateAsync(Order entity)
        {
            await unıtOfWork.GetRepository<Order>().UpdateAsync(entity);
            await unıtOfWork.SaveAsync();
            return entity;
        }
    }
}
