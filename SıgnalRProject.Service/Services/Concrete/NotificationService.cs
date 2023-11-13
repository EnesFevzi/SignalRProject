using SıgnalRProject.DataAccess.UnıtOfWorks;
using SıgnalRProject.Entity.Entities;
using SıgnalRProject.Service.Services.Abstract;
using System.Linq.Expressions;

namespace SıgnalRProject.Service.Services.Concrete
{
    public class NotificationService : INotificationService
    {
        private readonly IUnıtOfWork unıtOfWork;

        public NotificationService(IUnıtOfWork unıtOfWork)
        {
            this.unıtOfWork = unıtOfWork;
        }
        public async  Task AddAsync(Notification entity)
        {
            await unıtOfWork.GetRepository<Notification>().AddAsync(entity);
            await unıtOfWork.SaveAsync();
        }

        public Task<bool> AnyAsync(Expression<Func<Notification, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<int> CountAsync(Expression<Func<Notification, bool>> predicate = null)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(Notification entity)
        {
            await unıtOfWork.GetRepository<Notification>().DeleteAsync(entity);
            await unıtOfWork.SaveAsync();
        }

        public async Task<List<Notification>> GetAllAsync(Expression<Func<Notification, bool>> predicate = null, params Expression<Func<Notification, object>>[] includeProperties)
        {
            return await unıtOfWork.GetRepository<Notification>().GetAllAsync(predicate, includeProperties);
        }

        public async Task<List<Notification>> GetAllAsync(params Expression<Func<Notification, object>>[] includeProperties)
        {
            return await unıtOfWork.GetRepository<Notification>().GetAllAsync(includeProperties);
        }

        public async Task<Notification> GetAsync(Expression<Func<Notification, bool>> predicate, params Expression<Func<Notification, object>>[] includeProperties)
        {
            return await unıtOfWork.GetRepository<Notification>().GetAsync(predicate, includeProperties);
        }

        public async Task<Notification> GetAsync(params Expression<Func<Notification, object>>[] includeProperties)
        {
            return await unıtOfWork.GetRepository<Notification>().GetAsync(includeProperties);
        }

        public async Task<Notification> GetByGuidAsync(Guid id)
        {
            return await unıtOfWork.GetRepository<Notification>().GetByGuidAsync(id);
        }

        public async Task<Notification> GetByIDAsync(int id)
        {
            return await unıtOfWork.GetRepository<Notification>().GetByIDAsync(id);
        }

        public async Task UpdateAsync(Notification entity)
        {
            await unıtOfWork.GetRepository<Notification>().UpdateAsync(entity);
            await unıtOfWork.SaveAsync();
        }
    }
}
