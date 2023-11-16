using SıgnalRProject.DataAccess.UnıtOfWorks;
using SıgnalRProject.Entity.Entities;
using SıgnalRProject.Service.Services.Abstract;
using System.Linq.Expressions;

namespace SıgnalRProject.Service.Services.Concrete
{
    public class MoneyCaseService : IMoneyCaseService
    {
        private readonly IUnıtOfWork unıtOfWork;

        public MoneyCaseService(IUnıtOfWork unıtOfWork)
        {
            this.unıtOfWork = unıtOfWork;
        }
        public async Task<MoneyCase> AddAsync(MoneyCase entity)
        {
            await unıtOfWork.GetRepository<MoneyCase>().AddAsync(entity);
            await unıtOfWork.SaveAsync();
            return entity;
        }

        public Task<bool> AnyAsync(Expression<Func<MoneyCase, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<int> CountAsync(Expression<Func<MoneyCase, bool>> predicate = null)
        {
            throw new NotImplementedException();
        }

        public async Task<MoneyCase> DeleteAsync(MoneyCase entity)
        {
            await unıtOfWork.GetRepository<MoneyCase>().DeleteAsync(entity);
            await unıtOfWork.SaveAsync();
            return entity;
        }

        public async Task<List<MoneyCase>> GetAllAsync(Expression<Func<MoneyCase, bool>> predicate = null, params Expression<Func<MoneyCase, object>>[] includeProperties)
        {
            return await unıtOfWork.GetRepository<MoneyCase>().GetAllAsync(predicate, includeProperties);
        }

        public async Task<List<MoneyCase>> GetAllAsync(params Expression<Func<MoneyCase, object>>[] includeProperties)
        {
            return await unıtOfWork.GetRepository<MoneyCase>().GetAllAsync(includeProperties);
        }

        public async Task<MoneyCase> GetAsync(Expression<Func<MoneyCase, bool>> predicate, params Expression<Func<MoneyCase, object>>[] includeProperties)
        {
            return await unıtOfWork.GetRepository<MoneyCase>().GetAsync(predicate, includeProperties);
        }

        public async Task<MoneyCase> GetAsync(params Expression<Func<MoneyCase, object>>[] includeProperties)
        {
            return await unıtOfWork.GetRepository<MoneyCase>().GetAsync(includeProperties);
        }

        public async Task<MoneyCase> GetByGuidAsync(Guid id)
        {
            return await unıtOfWork.GetRepository<MoneyCase>().GetByGuidAsync(id);
        }

        public async Task<MoneyCase> GetByIDAsync(int id)
        {
            return await unıtOfWork.GetRepository<MoneyCase>().GetByIDAsync(id);
        }

        public async Task<decimal> TotalMoneyCaseAmount()
        {
            var moneycases = await unıtOfWork.GetRepository<MoneyCase>().GetAllAsync();

            var value = moneycases.Select(x => x.TotalAmount).FirstOrDefault();

            return value;
        }

        public async Task<MoneyCase> UpdateAsync(MoneyCase entity)
        {
            await unıtOfWork.GetRepository<MoneyCase>().UpdateAsync(entity);
            await unıtOfWork.SaveAsync();
            return entity;
        }
    }
}
