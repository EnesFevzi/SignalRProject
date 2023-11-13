using SıgnalRProject.DataAccess.UnıtOfWorks;
using SıgnalRProject.Entity.Entities;
using SıgnalRProject.Service.Services.Abstract;
using System.Linq.Expressions;

namespace SıgnalRProject.Service.Services.Concrete
{
    public class AboutService : IAboutService
    {
        private readonly IUnıtOfWork unıtOfWork;

        public AboutService(IUnıtOfWork unıtOfWork)
        {
            this.unıtOfWork = unıtOfWork;
        }

        public async Task AddAsync(About entity)
        {
            await unıtOfWork.GetRepository<About>().AddAsync(entity);
            await unıtOfWork.SaveAsync();
        }

        public Task<bool> AnyAsync(Expression<Func<About, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<int> CountAsync(Expression<Func<About, bool>> predicate = null)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(About entity)
        {
            await unıtOfWork.GetRepository<About>().DeleteAsync(entity);
            await unıtOfWork.SaveAsync();
        }

        public async Task<List<About>> GetAllAsync(Expression<Func<About, bool>> predicate = null, params Expression<Func<About, object>>[] includeProperties)
        {
           return await unıtOfWork.GetRepository<About>().GetAllAsync(predicate, includeProperties);
        }

        public async Task<List<About>> GetAllAsync(params Expression<Func<About, object>>[] includeProperties)
        {
            return await unıtOfWork.GetRepository<About>().GetAllAsync(includeProperties);
        }

        public async Task<About> GetAsync(Expression<Func<About, bool>> predicate, params Expression<Func<About, object>>[] includeProperties)
        {
            return await unıtOfWork.GetRepository<About>().GetAsync(predicate, includeProperties);
        }

        public async Task<About> GetAsync(params Expression<Func<About, object>>[] includeProperties)
        {
            return await unıtOfWork.GetRepository<About>().GetAsync(includeProperties);
        }

        public  async Task<About> GetByGuidAsync(Guid id)
        {
           return await unıtOfWork.GetRepository<About>().GetByGuidAsync(id);
        }

        public async Task<About> GetByIDAsync(int id)
        {
            return await unıtOfWork.GetRepository<About>().GetByIDAsync(id);
        }

        public async Task UpdateAsync(About entity)
        {
            await unıtOfWork.GetRepository<About>().UpdateAsync(entity);
            await unıtOfWork.SaveAsync();
        }
    }
}
