using SıgnalRProject.Entity.Entities;

namespace SıgnalRProject.Service.Services.Abstract
{
    public interface IOrderService : IService<Order>
    {
        Task<int> TotalOrderCount();
        Task<int> ActiveOrderCount();
        Task<decimal> LastOrderPrice();
        Task<decimal> TodayTotalPrice();
    }
}
