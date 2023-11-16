using SıgnalRProject.DataAccess.UnıtOfWorks;
using SıgnalRProject.Entity.Entities;
using SıgnalRProject.Service.Services.Abstract;
using System.Linq.Expressions;

namespace SıgnalRProject.Service.Services.Concrete
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnıtOfWork unıtOfWork;

        public CategoryService(IUnıtOfWork unıtOfWork)
        {
            this.unıtOfWork = unıtOfWork;
        }
        public async Task<Category> AddAsync(Category entity)
        {
            await unıtOfWork.GetRepository<Category>().AddAsync(entity);
            await unıtOfWork.SaveAsync();
            return entity;
        }

        public Task<bool> AnyAsync(Expression<Func<Category, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<int> CountAsync(Expression<Func<Category, bool>> predicate = null)
        {
            throw new NotImplementedException();
        }

        public async Task<Category> DeleteAsync(Category entity)
        {
            await unıtOfWork.GetRepository<Category>().DeleteAsync(entity);
            await unıtOfWork.SaveAsync();
            return entity;
        }

        public async Task<List<Category>> GetAllAsync(Expression<Func<Category, bool>> predicate = null, params Expression<Func<Category, object>>[] includeProperties)
        {
            return await unıtOfWork.GetRepository<Category>().GetAllAsync(predicate, includeProperties);
        }

        public async Task<List<Category>> GetAllAsync(params Expression<Func<Category, object>>[] includeProperties)
        {
            return await unıtOfWork.GetRepository<Category>().GetAllAsync(includeProperties);
        }

        public async Task<Category> GetAsync(Expression<Func<Category, bool>> predicate, params Expression<Func<Category, object>>[] includeProperties)
        {
            return await unıtOfWork.GetRepository<Category>().GetAsync(predicate, includeProperties);
        }

        public async Task<Category> GetAsync(params Expression<Func<Category, object>>[] includeProperties)
        {
            return await unıtOfWork.GetRepository<Category>().GetAsync(includeProperties);
        }

        public async Task<Category> GetByGuidAsync(Guid id)
        {
            return await unıtOfWork.GetRepository<Category>().GetByGuidAsync(id);
        }

        public async Task<Category> GetByIDAsync(int id)
        {
            return await unıtOfWork.GetRepository<Category>().GetByIDAsync(id);
        }

        public async Task<Category> UpdateAsync(Category entity)
        {
            await unıtOfWork.GetRepository<Category>().UpdateAsync(entity);
            await unıtOfWork.SaveAsync();
            return entity;
        }
    }
}
