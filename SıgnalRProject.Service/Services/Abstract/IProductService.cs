using SıgnalRProject.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SıgnalRProject.Service.Services.Abstract
{
    public interface IProductService : IService<Product>
    {
        Task<List<Product>> GetProductsWithCategories();
        Task<int> ProductCount();
        Task<int> ProductCountByCategoryNameHamburger();
        Task<int> ProductCountByCategoryNameDrink();
        Task<decimal> ProductPriceAvg();
        Task<string> ProductNameByMaxPrice();
        Task<string> ProductNameByMinPrice();
        Task<decimal> ProductAvgPriceByHamburger();
        Task<decimal> ProductPriceBySteakBurger();
        Task<decimal> TotalPriceByDrinkCategory();
        Task<decimal> TotalPriceBySaladCategory();
    }
}
