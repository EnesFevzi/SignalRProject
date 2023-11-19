using SıgnalRProject.Entity.Entities;

namespace SıgnalRProject.Service.Services.Abstract
{
    public interface INotificationService : IService<Notification>
    {
        Task<int> NotificationCountByStatusFalse();
        Task<List<Notification>> GetAllNotificationByFalse();
        Task NotificationStatusChangeToTrue(int id);
        Task NotificationStatusChangeToFalse(int id);
    }
}
