using SıgnalRProject.Dto.BasketDto;
using SıgnalRProject.Entity.Entities;

namespace SıgnalRProject.Service.Services.Abstract
{
    public interface IBasketService : IService<Basket>
    {
        Task<List<Basket>> GetBasketByMenuTableNumber(int id);
        Task<List<ResultBasketDto>> BasketListByMenuTableWithProductName(int menuTableId);
    }
}
