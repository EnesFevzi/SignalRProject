using SıgnalRProject.DataAccess.UnıtOfWorks;
using SıgnalRProject.Entity.Entities;
using SıgnalRProject.Service.Services.Abstract;
using System.Linq.Expressions;

namespace SıgnalRProject.Service.Services.Concrete
{
    public class MenuTableService : IMenuTableService
    {
        private readonly IUnıtOfWork unıtOfWork;

        public MenuTableService(IUnıtOfWork unıtOfWork)
        {
            this.unıtOfWork = unıtOfWork;
        }
        public async Task<MenuTable> AddAsync(MenuTable entity)
        {
            await unıtOfWork.GetRepository<MenuTable>().AddAsync(entity);
            await unıtOfWork.SaveAsync();
            return entity;
        }

        public Task<bool> AnyAsync(Expression<Func<MenuTable, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<int> CountAsync(Expression<Func<MenuTable, bool>> predicate = null)
        {
            throw new NotImplementedException();
        }

        public async Task<MenuTable> DeleteAsync(MenuTable entity)
        {
            await unıtOfWork.GetRepository<MenuTable>().DeleteAsync(entity);
            await unıtOfWork.SaveAsync();
            return entity;
        }

        public async Task<List<MenuTable>> GetAllAsync(Expression<Func<MenuTable, bool>> predicate = null, params Expression<Func<MenuTable, object>>[] includeProperties)
        {
            return await unıtOfWork.GetRepository<MenuTable>().GetAllAsync(predicate, includeProperties);
        }

        public async Task<List<MenuTable>> GetAllAsync(params Expression<Func<MenuTable, object>>[] includeProperties)
        {
            return await unıtOfWork.GetRepository<MenuTable>().GetAllAsync(includeProperties);
        }

        public async Task<MenuTable> GetAsync(Expression<Func<MenuTable, bool>> predicate, params Expression<Func<MenuTable, object>>[] includeProperties)
        {
            return await unıtOfWork.GetRepository<MenuTable>().GetAsync(predicate, includeProperties);
        }

        public async Task<MenuTable> GetAsync(params Expression<Func<MenuTable, object>>[] includeProperties)
        {
            return await unıtOfWork.GetRepository<MenuTable>().GetAsync(includeProperties);
        }

        public async Task<MenuTable> GetByGuidAsync(Guid id)
        {
            return await unıtOfWork.GetRepository<MenuTable>().GetByGuidAsync(id);
        }

        public async Task<MenuTable> GetByIDAsync(int id)
        {
            return await unıtOfWork.GetRepository<MenuTable>().GetByIDAsync(id);
        }

        public async Task<int> MenuTableCount()
        {
           var value = await unıtOfWork.GetRepository<MenuTable>().CountAsync();
            return value;
        }

        public async Task<MenuTable> UpdateAsync(MenuTable entity)
        {
            await unıtOfWork.GetRepository<MenuTable>().UpdateAsync(entity);
            await unıtOfWork.SaveAsync();
            return entity;
        }
    }
}
