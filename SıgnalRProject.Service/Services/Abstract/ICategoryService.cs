using SıgnalRProject.Entity.Entities;

namespace SıgnalRProject.Service.Services.Abstract
{
    public interface ICategoryService : IService<Category>
    {
        Task<int> CategoryCount();
        Task<int> ActiveCategoryCount();
        Task<int> PassiveCategoryCount();
    }
}
