using SıgnalRProject.DataAccess.UnıtOfWorks;
using SıgnalRProject.Entity.Entities;
using SıgnalRProject.Service.Services.Abstract;
using System.Linq.Expressions;

namespace SıgnalRProject.Service.Services.Concrete
{
    public class SliderService : ISliderService
    {
        private readonly IUnıtOfWork unıtOfWork;

        public SliderService(IUnıtOfWork unıtOfWork)
        {
            this.unıtOfWork = unıtOfWork;
        }
        public async Task AddAsync(Slider entity)
        {
            await unıtOfWork.GetRepository<Slider>().AddAsync(entity);
            await unıtOfWork.SaveAsync();
        }

        public Task<bool> AnyAsync(Expression<Func<Slider, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<int> CountAsync(Expression<Func<Slider, bool>> predicate = null)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(Slider entity)
        {
            await unıtOfWork.GetRepository<Slider>().DeleteAsync(entity);
            await unıtOfWork.SaveAsync();
        }

        public async Task<List<Slider>> GetAllAsync(Expression<Func<Slider, bool>> predicate = null, params Expression<Func<Slider, object>>[] includeProperties)
        {
            return await unıtOfWork.GetRepository<Slider>().GetAllAsync(predicate, includeProperties);
        }

        public async Task<List<Slider>> GetAllAsync(params Expression<Func<Slider, object>>[] includeProperties)
        {
            return await unıtOfWork.GetRepository<Slider>().GetAllAsync(includeProperties);
        }

        public async Task<Slider> GetAsync(Expression<Func<Slider, bool>> predicate, params Expression<Func<Slider, object>>[] includeProperties)
        {
            return await unıtOfWork.GetRepository<Slider>().GetAsync(predicate, includeProperties);
        }
         
        public async Task<Slider> GetAsync(params Expression<Func<Slider, object>>[] includeProperties)
        {
            return await unıtOfWork.GetRepository<Slider>().GetAsync(includeProperties);
        }

        public async  Task<Slider> GetByGuidAsync(Guid id)
        {
            return await unıtOfWork.GetRepository<Slider>().GetByGuidAsync(id);
        }

        public async Task<Slider> GetByIDAsync(int id)
        {
            return await unıtOfWork.GetRepository<Slider>().GetByIDAsync(id);
        }

        public async Task UpdateAsync(Slider entity)
        {
            await unıtOfWork.GetRepository<Slider>().UpdateAsync(entity);
            await unıtOfWork.SaveAsync();
        }
    }
}
