using SıgnalRProject.DataAccess.UnıtOfWorks;
using SıgnalRProject.Entity.Entities;
using SıgnalRProject.Service.Services.Abstract;
using System.Linq.Expressions;

namespace SıgnalRProject.Service.Services.Concrete
{
    public class DiscountService : IDiscountService
    {
        private readonly IUnıtOfWork unıtOfWork;

        public DiscountService(IUnıtOfWork unıtOfWork)
        {
            this.unıtOfWork = unıtOfWork;
        }
        public async Task<Discount> AddAsync(Discount entity)
        {
            await unıtOfWork.GetRepository<Discount>().AddAsync(entity);
            await unıtOfWork.SaveAsync();
            return entity;
        }

        public Task<bool> AnyAsync(Expression<Func<Discount, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public async Task ChangeStatusToFalse(int id)
        {
            var discount = await unıtOfWork.GetRepository<Discount>().GetAsync(x => x.DiscountID == id);
            discount.Status = false;
            await unıtOfWork.GetRepository<Discount>().UpdateAsync(discount);
            await unıtOfWork.SaveAsync();
        }

        public async Task ChangeStatusToTrue(int id)
        {
            var discount = await unıtOfWork.GetRepository<Discount>().GetAsync(x => x.DiscountID == id);
            discount.Status = true;
            await unıtOfWork.GetRepository<Discount>().UpdateAsync(discount);
            await unıtOfWork.SaveAsync();
        }

        public Task<int> CountAsync(Expression<Func<Discount, bool>> predicate = null)
        {
            throw new NotImplementedException();
        }

        public async Task<Discount> DeleteAsync(Discount entity)
        {
            await unıtOfWork.GetRepository<Discount>().DeleteAsync(entity);
            await unıtOfWork.SaveAsync();
            return entity;
        }

        public async Task<List<Discount>> GetAllAsync(Expression<Func<Discount, bool>> predicate = null, params Expression<Func<Discount, object>>[] includeProperties)
        {
            return await unıtOfWork.GetRepository<Discount>().GetAllAsync(predicate, includeProperties);
        }

        public async Task<List<Discount>> GetAllAsync(params Expression<Func<Discount, object>>[] includeProperties)
        {
            return await unıtOfWork.GetRepository<Discount>().GetAllAsync(includeProperties);
        }

        public async Task<Discount> GetAsync(Expression<Func<Discount, bool>> predicate, params Expression<Func<Discount, object>>[] includeProperties)
        {
            return await unıtOfWork.GetRepository<Discount>().GetAsync(predicate, includeProperties);
        }

        public async Task<Discount> GetAsync(params Expression<Func<Discount, object>>[] includeProperties)
        {
            return await unıtOfWork.GetRepository<Discount>().GetAsync(includeProperties);
        }

        public async Task<Discount> GetByGuidAsync(Guid id)
        {
            return await unıtOfWork.GetRepository<Discount>().GetByGuidAsync(id);
        }

        public async Task<Discount> GetByIDAsync(int id)
        {
            return await unıtOfWork.GetRepository<Discount>().GetByIDAsync(id);
        }

        public async Task<List<Discount>> GetListByStatusTrue()
        {
           var discount = await unıtOfWork.GetRepository<Discount>().GetAllAsync(x => x.Status == true);
            return discount;
        }

        public async Task<Discount> UpdateAsync(Discount entity)
        {
            await unıtOfWork.GetRepository<Discount>().UpdateAsync(entity);
            await unıtOfWork.SaveAsync();
            return entity;
        }
    }
}
