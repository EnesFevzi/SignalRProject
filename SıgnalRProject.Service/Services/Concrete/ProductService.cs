using SıgnalRProject.DataAccess.UnıtOfWorks;
using SıgnalRProject.Entity.Entities;
using SıgnalRProject.Service.Services.Abstract;
using System.Linq.Expressions;

namespace SıgnalRProject.Service.Services.Concrete
{
    public class ProductService : IProductService
    {
        private readonly IUnıtOfWork unıtOfWork;

        public ProductService(IUnıtOfWork unıtOfWork)
        {
            this.unıtOfWork = unıtOfWork;
        }
        public async Task<Product> AddAsync(Product entity)
        {
            await unıtOfWork.GetRepository<Product>().AddAsync(entity);
            await unıtOfWork.SaveAsync();
            return entity;
        }

        public Task<bool> AnyAsync(Expression<Func<Product, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<int> CountAsync(Expression<Func<Product, bool>> predicate = null)
        {
            throw new NotImplementedException();
        }

        public async Task<Product> DeleteAsync(Product entity)
        {
            await unıtOfWork.GetRepository<Product>().DeleteAsync(entity);
            await unıtOfWork.SaveAsync();
            return entity;
        }

        public async Task<List<Product>> GetAllAsync(Expression<Func<Product, bool>> predicate = null, params Expression<Func<Product, object>>[] includeProperties)
        {
            return await unıtOfWork.GetRepository<Product>().GetAllAsync(predicate, includeProperties);
        }

        public async Task<List<Product>> GetAllAsync(params Expression<Func<Product, object>>[] includeProperties)
        {
            return await unıtOfWork.GetRepository<Product>().GetAllAsync(includeProperties);
        }

        public async Task<Product> GetAsync(Expression<Func<Product, bool>> predicate, params Expression<Func<Product, object>>[] includeProperties)
        {
            return await unıtOfWork.GetRepository<Product>().GetAsync(predicate, includeProperties);
        }

        public async Task<Product> GetAsync(params Expression<Func<Product, object>>[] includeProperties)
        {
            return await unıtOfWork.GetRepository<Product>().GetAsync(includeProperties);
        }

        public async Task<Product> GetByGuidAsync(Guid id)
        {
            return await unıtOfWork.GetRepository<Product>().GetByGuidAsync(id);
        }

        public async Task<Product> GetByIDAsync(int id)
        {
            return await unıtOfWork.GetRepository<Product>().GetByIDAsync(id);
        }

        public async Task<Product> UpdateAsync(Product entity)
        {
            await unıtOfWork.GetRepository<Product>().UpdateAsync(entity);
            await unıtOfWork.SaveAsync();
            return entity;
        }
    }
}
