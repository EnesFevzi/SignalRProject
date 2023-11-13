using SıgnalRProject.DataAccess.UnıtOfWorks;
using SıgnalRProject.Entity.Entities;
using SıgnalRProject.Service.Services.Abstract;
using System.Linq.Expressions;

namespace SıgnalRProject.Service.Services.Concrete
{
    public class TestimonialService : ITestimonialService
    {
        private readonly IUnıtOfWork unıtOfWork;

        public TestimonialService(IUnıtOfWork unıtOfWork)
        {
            this.unıtOfWork = unıtOfWork;
        }
        public async Task AddAsync(Testimonial entity)
        {
            await unıtOfWork.GetRepository<Testimonial>().AddAsync(entity);
            await unıtOfWork.SaveAsync();
        }

        public Task<bool> AnyAsync(Expression<Func<Testimonial, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<int> CountAsync(Expression<Func<Testimonial, bool>> predicate = null)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(Testimonial entity)
        {
            await unıtOfWork.GetRepository<Testimonial>().DeleteAsync(entity);
            await unıtOfWork.SaveAsync();
        }

        public async Task<List<Testimonial>> GetAllAsync(Expression<Func<Testimonial, bool>> predicate = null, params Expression<Func<Testimonial, object>>[] includeProperties)
        {
            return await unıtOfWork.GetRepository<Testimonial>().GetAllAsync(predicate, includeProperties);
        }

        public async Task<List<Testimonial>> GetAllAsync(params Expression<Func<Testimonial, object>>[] includeProperties)
        {
            return await unıtOfWork.GetRepository<Testimonial>().GetAllAsync( includeProperties);
        }

        public async Task<Testimonial> GetAsync(Expression<Func<Testimonial, bool>> predicate, params Expression<Func<Testimonial, object>>[] includeProperties)
        {
            return await unıtOfWork.GetRepository<Testimonial>().GetAsync(predicate, includeProperties);
        }

        public async Task<Testimonial> GetAsync(params Expression<Func<Testimonial, object>>[] includeProperties)
        {
            return await unıtOfWork.GetRepository<Testimonial>().GetAsync(includeProperties);
        }

        public async Task<Testimonial> GetByGuidAsync(Guid id)
        {
            return await unıtOfWork.GetRepository<Testimonial>().GetByGuidAsync(id);
        }

        public async Task<Testimonial> GetByIDAsync(int id)
        {
            return await unıtOfWork.GetRepository<Testimonial>().GetByIDAsync(id);
        }

        public async Task UpdateAsync(Testimonial entity)
        {
            await unıtOfWork.GetRepository<Testimonial>().UpdateAsync(entity);
            await unıtOfWork.SaveAsync();
        }
    }
}
