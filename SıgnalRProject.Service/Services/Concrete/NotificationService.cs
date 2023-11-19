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
        public async Task<Notification> AddAsync(Notification entity)
        {
            await unıtOfWork.GetRepository<Notification>().AddAsync(entity);
            await unıtOfWork.SaveAsync();
            return entity;
        }

        public Task<bool> AnyAsync(Expression<Func<Notification, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<int> CountAsync(Expression<Func<Notification, bool>> predicate = null)
        {
            throw new NotImplementedException();
        }

        public async Task<Notification> DeleteAsync(Notification entity)
        {
            await unıtOfWork.GetRepository<Notification>().DeleteAsync(entity);
            await unıtOfWork.SaveAsync();
            return entity;
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

        public async Task<int> NotificationCountByStatusFalse()
        {
            var notification = await unıtOfWork.GetRepository<Notification>().CountAsync();
            return notification;
        }

        public async Task NotificationStatusChangeToFalse(int id)
        {
            var notification = await unıtOfWork.GetRepository<Notification>().GetAsync(x => x.NotificationID == id);
            notification.Status = false;
            await unıtOfWork.GetRepository<Notification>().UpdateAsync(notification);
            await unıtOfWork.SaveAsync();

        }

        public async Task NotificationStatusChangeToTrue(int id)
        {
            var notification = await unıtOfWork.GetRepository<Notification>().GetAsync(x => x.NotificationID == id);
            notification.Status = true;
            await unıtOfWork.GetRepository<Notification>().UpdateAsync(notification);
            await unıtOfWork.SaveAsync();
        }
        public async Task<List<Notification>> GetAllNotificationByFalse()
        {
            var notifications = await unıtOfWork.GetRepository<Notification>().GetAllAsync(x => x.Status == false);
            return notifications;
        }

        public async Task<Notification> UpdateAsync(Notification entity)
        {
            await unıtOfWork.GetRepository<Notification>().UpdateAsync(entity);
            await unıtOfWork.SaveAsync();
            return entity;
        }
    }
}
