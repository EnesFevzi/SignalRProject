using SıgnalRProject.DataAccess.UnıtOfWorks;
using SıgnalRProject.Entity.Entities;
using SıgnalRProject.Service.Services.Abstract;
using System.Linq.Expressions;

namespace SıgnalRProject.Service.Services.Concrete
{
    public class FeatureService : IFeatureService
    {
        private readonly IUnıtOfWork unıtOfWork;

        public FeatureService(IUnıtOfWork unıtOfWork)
        {
            this.unıtOfWork = unıtOfWork;
        }
        public async Task AddAsync(Feature entity)
        {
            await unıtOfWork.GetRepository<Feature>().AddAsync(entity);
            await unıtOfWork.SaveAsync();
        }

        public Task<bool> AnyAsync(Expression<Func<Feature, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<int> CountAsync(Expression<Func<Feature, bool>> predicate = null)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(Feature entity)
        {
            await unıtOfWork.GetRepository<Feature>().DeleteAsync(entity);
            await unıtOfWork.SaveAsync();
        }

        public async Task<List<Feature>> GetAllAsync(Expression<Func<Feature, bool>> predicate = null, params Expression<Func<Feature, object>>[] includeProperties)
        {
            return await unıtOfWork.GetRepository<Feature>().GetAllAsync(predicate, includeProperties);
        }

        public async Task<List<Feature>> GetAllAsync(params Expression<Func<Feature, object>>[] includeProperties)
        {
            return await unıtOfWork.GetRepository<Feature>().GetAllAsync(includeProperties);
        }

        public async Task<Feature> GetAsync(Expression<Func<Feature, bool>> predicate, params Expression<Func<Feature, object>>[] includeProperties)
        {
            return await unıtOfWork.GetRepository<Feature>().GetAsync(predicate, includeProperties);
        }

        public async Task<Feature> GetAsync(params Expression<Func<Feature, object>>[] includeProperties)
        {
            return await unıtOfWork.GetRepository<Feature>().GetAsync(includeProperties);
        }

        public async Task<Feature> GetByGuidAsync(Guid id)
        {
            return await unıtOfWork.GetRepository<Feature>().GetByGuidAsync(id);
        }

        public async Task<Feature> GetByIDAsync(int id)
        {
            return await unıtOfWork.GetRepository<Feature>().GetByIDAsync(id);
        }

        public async Task UpdateAsync(Feature entity)
        {
            await unıtOfWork.GetRepository<Feature>().UpdateAsync(entity);
            await unıtOfWork.SaveAsync();
        }
    }
}
