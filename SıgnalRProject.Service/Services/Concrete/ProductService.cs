using SıgnalRProject.DataAccess.UnıtOfWorks;
using SıgnalRProject.Entity.Entities;
using SıgnalRProject.Service.Services.Abstract;
using System.Linq.Expressions;

namespace SıgnalRProject.Service.Services.Concrete
{
    public class ProductService : IProductService
    {
        private readonly IUnıtOfWork unıtOfWork;

        public ProductService(IUnıtOfWork unıtOfWork)
        {
            this.unıtOfWork = unıtOfWork;
        }
        public async Task<Product> AddAsync(Product entity)
        {
            await unıtOfWork.GetRepository<Product>().AddAsync(entity);
            await unıtOfWork.SaveAsync();
            return entity;
        }

        public Task<bool> AnyAsync(Expression<Func<Product, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<int> CountAsync(Expression<Func<Product, bool>> predicate = null)
        {
            throw new NotImplementedException();
        }

        public async Task<Product> DeleteAsync(Product entity)
        {
            await unıtOfWork.GetRepository<Product>().DeleteAsync(entity);
            await unıtOfWork.SaveAsync();
            return entity;
        }

        public async Task<List<Product>> GetAllAsync(Expression<Func<Product, bool>> predicate = null, params Expression<Func<Product, object>>[] includeProperties)
        {
            return await unıtOfWork.GetRepository<Product>().GetAllAsync(predicate, includeProperties);
        }

        public async Task<List<Product>> GetAllAsync(params Expression<Func<Product, object>>[] includeProperties)
        {
            return await unıtOfWork.GetRepository<Product>().GetAllAsync(includeProperties);
        }

        public async Task<Product> GetAsync(Expression<Func<Product, bool>> predicate, params Expression<Func<Product, object>>[] includeProperties)
        {
            return await unıtOfWork.GetRepository<Product>().GetAsync(predicate, includeProperties);
        }

        public async Task<Product> GetAsync(params Expression<Func<Product, object>>[] includeProperties)
        {
            return await unıtOfWork.GetRepository<Product>().GetAsync(includeProperties);
        }

        public async Task<Product> GetByGuidAsync(Guid id)
        {
            return await unıtOfWork.GetRepository<Product>().GetByGuidAsync(id);
        }

        public async Task<Product> GetByIDAsync(int id)
        {
            return await unıtOfWork.GetRepository<Product>().GetByIDAsync(id);
        }

        public async Task<List<Product>> GetProductsWithCategories()
        {
            return await unıtOfWork.GetRepository<Product>().GetAllAsync(x => x.Category);
        }

        public async Task<decimal> ProductAvgPriceByHamburger()
        {
            var hamburgerCategory = await unıtOfWork.GetRepository<Category>().GetAsync(x => x.CategoryName == "Hamburgerler");
            var products = await unıtOfWork.GetRepository<Product>().GetAllAsync(x => x.CategoryID == hamburgerCategory.CategoryID);
            var average = products.Average(x => x.Price);
            return average;

        }

        public async Task<int> ProductCount()
        {
            return await unıtOfWork.GetRepository<Product>().CountAsync();
        }

        public async Task<int> ProductCountByCategoryNameDrink()
        {
            //var hamburgerCategory = await unıtOfWork.GetRepository<Category>().GetAsync(x => x.CategoryName == "İçecek");
            var products = await unıtOfWork.GetRepository<Product>().CountAsync(x => x.Category.CategoryName == "İçecek");
            return products;
        }

        public async Task<int> ProductCountByCategoryNameHamburger()
        {
            //var hamburgerCategory = await unıtOfWork.GetRepository<Category>().GetAsync(x => x.CategoryName == "Hamburger");
            var products = await unıtOfWork.GetRepository<Product>().CountAsync(x => x.Category.CategoryName == "Hamburgerler");
            return products;
        }

        public async Task<string> ProductNameByMaxPrice()
        {
            var products = await unıtOfWork.GetRepository<Product>().GetAllAsync();
            var maxprice = products.Max(x => x.Price);
            var maxPriceProduct = await unıtOfWork.GetRepository<Product>()
            .GetAsync(x => x.Price == maxprice);
            return maxPriceProduct.ProductName;

        }

        public async Task<string> ProductNameByMinPrice()
        {
            var products = await unıtOfWork.GetRepository<Product>().GetAllAsync();
            var maxprice = products.Min(x => x.Price);
            var maxPriceProduct = await unıtOfWork.GetRepository<Product>()
            .GetAsync(x => x.Price == maxprice);
            return maxPriceProduct.ProductName;
        }

        public async Task<decimal> ProductPriceAvg()
        {
            var products = await unıtOfWork.GetRepository<Product>().GetAllAsync();
            var average = products.Average(x => x.Price);
            return average;
        }

        public async Task<decimal> ProductPriceBySteakBurger()
        {
            var products = await unıtOfWork.GetRepository<Product>().GetAsync(x => x.ProductName == "Steak Burger");
            return products.Price;
        }

        public async Task<decimal> TotalPriceByDrinkCategory()
        {
            var category = await unıtOfWork.GetRepository<Category>().GetAsync(x => x.CategoryName == "İçecek");
            var products = await unıtOfWork.GetRepository<Product>().GetAllAsync(x => x.CategoryID == category.CategoryID);
            return products.Sum(x => x.Price);

        }

        public async Task<decimal> TotalPriceBySaladCategory()
        {
            var category = await unıtOfWork.GetRepository<Category>().GetAsync(x => x.CategoryName == "Salata");
            var products = await unıtOfWork.GetRepository<Product>().GetAllAsync(x => x.CategoryID == category.CategoryID);
            return products.Sum(x => x.Price);
        }

        public async Task<Product> UpdateAsync(Product entity)
        {
            await unıtOfWork.GetRepository<Product>().UpdateAsync(entity);
            await unıtOfWork.SaveAsync();
            return entity;
        }
    }
}
