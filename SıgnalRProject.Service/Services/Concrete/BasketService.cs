using SıgnalRProject.DataAccess.UnıtOfWorks;
using SıgnalRProject.Entity.Entities;
using SıgnalRProject.Service.Services.Abstract;
using System.Linq.Expressions;


namespace SıgnalRProject.Service.Services.Concrete
{
    public class BasketService : IBasketService
    {
        private readonly IUnıtOfWork unıtOfWork;

        public BasketService(IUnıtOfWork unıtOfWork)
        {
            this.unıtOfWork = unıtOfWork;
        }

        public async Task AddAsync(Basket entity)
        {
            await unıtOfWork.GetRepository<Basket>().AddAsync(entity);
            await unıtOfWork.SaveAsync();
        }

        public Task<bool> AnyAsync(Expression<Func<Basket, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<int> CountAsync(Expression<Func<Basket, bool>> predicate = null)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(Basket entity)
        {
            await unıtOfWork.GetRepository<Basket>().DeleteAsync(entity);
            await unıtOfWork.SaveAsync();
        }

        public async Task<List<Basket>> GetAllAsync(Expression<Func<Basket, bool>> predicate = null, params Expression<Func<Basket, object>>[] includeProperties)
        {
            return await unıtOfWork.GetRepository<Basket>().GetAllAsync(predicate, includeProperties);
        }

        public async Task<List<Basket>> GetAllAsync(params Expression<Func<Basket, object>>[] includeProperties)
        {
            return await unıtOfWork.GetRepository<Basket>().GetAllAsync(includeProperties);
        }

        public async Task<Basket> GetAsync(Expression<Func<Basket, bool>> predicate, params Expression<Func<Basket, object>>[] includeProperties)
        {
            return await unıtOfWork.GetRepository<Basket>().GetAsync(predicate,includeProperties);
        }

        public async Task<Basket> GetAsync(params Expression<Func<Basket, object>>[] includeProperties)
        {
            return await unıtOfWork.GetRepository<Basket>().GetAsync(includeProperties);
        }

        public async Task<Basket> GetByGuidAsync(Guid id)
        {
           return await unıtOfWork.GetRepository<Basket>().GetByGuidAsync(id);
        }

        public async Task<Basket> GetByIDAsync(int id)
        {
            return await unıtOfWork.GetRepository<Basket>().GetByIDAsync(id);
        }

        public async Task UpdateAsync(Basket entity)
        {
            await unıtOfWork.GetRepository<Basket>().DeleteAsync(entity);
            await unıtOfWork.SaveAsync();
        }
    }
}
