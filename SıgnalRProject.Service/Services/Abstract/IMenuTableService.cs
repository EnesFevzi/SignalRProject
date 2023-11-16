using SıgnalRProject.Entity.Entities;

namespace SıgnalRProject.Service.Services.Abstract
{
    public interface IMenuTableService:IService<MenuTable>
    {
       Task< int> MenuTableCount();
    }
}
