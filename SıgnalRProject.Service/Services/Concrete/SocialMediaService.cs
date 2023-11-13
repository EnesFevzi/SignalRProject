using SıgnalRProject.DataAccess.UnıtOfWorks;
using SıgnalRProject.Entity.Entities;
using SıgnalRProject.Service.Services.Abstract;
using System.Linq.Expressions;

namespace SıgnalRProject.Service.Services.Concrete
{
    public class SocialMediaService : ISocialMediaService
    {
        private readonly IUnıtOfWork unıtOfWork;

        public SocialMediaService(IUnıtOfWork unıtOfWork)
        {
            this.unıtOfWork = unıtOfWork;
        }
        public async Task AddAsync(SocialMedia entity)
        {
            await unıtOfWork.GetRepository<SocialMedia>().AddAsync(entity);
            await unıtOfWork.SaveAsync();
        }

        public Task<bool> AnyAsync(Expression<Func<SocialMedia, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<int> CountAsync(Expression<Func<SocialMedia, bool>> predicate = null)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(SocialMedia entity)
        {
            await unıtOfWork.GetRepository<SocialMedia>().DeleteAsync(entity);
            await unıtOfWork.SaveAsync();
        }

        public async Task<List<SocialMedia>> GetAllAsync(Expression<Func<SocialMedia, bool>> predicate = null, params Expression<Func<SocialMedia, object>>[] includeProperties)
        {
            return await unıtOfWork.GetRepository<SocialMedia>().GetAllAsync(predicate, includeProperties);
        }

        public async Task<List<SocialMedia>> GetAllAsync(params Expression<Func<SocialMedia, object>>[] includeProperties)
        {
            return await unıtOfWork.GetRepository<SocialMedia>().GetAllAsync(includeProperties);
        }

        public async Task<SocialMedia> GetAsync(Expression<Func<SocialMedia, bool>> predicate, params Expression<Func<SocialMedia, object>>[] includeProperties)
        {
            return await unıtOfWork.GetRepository<SocialMedia>().GetAsync(predicate, includeProperties);
        }

        public async Task<SocialMedia> GetAsync(params Expression<Func<SocialMedia, object>>[] includeProperties)
        {
            return await unıtOfWork.GetRepository<SocialMedia>().GetAsync(includeProperties);
        }

        public async Task<SocialMedia> GetByGuidAsync(Guid id)
        {
            return await unıtOfWork.GetRepository<SocialMedia>().GetByGuidAsync(id);
        }

        public async Task<SocialMedia> GetByIDAsync(int id)
        {
            return await unıtOfWork.GetRepository<SocialMedia>().GetByIDAsync(id);
        }

        public async Task UpdateAsync(SocialMedia entity)
        {
            await unıtOfWork.GetRepository<SocialMedia>().UpdateAsync(entity);
            await unıtOfWork.SaveAsync();
        }
    }
}
