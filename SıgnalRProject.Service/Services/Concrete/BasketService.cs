using SıgnalRProject.DataAccess.UnıtOfWorks;
using SıgnalRProject.Dto.BasketDto;
using SıgnalRProject.Entity.Entities;
using SıgnalRProject.Service.Services.Abstract;
using System.Linq.Expressions;


namespace SıgnalRProject.Service.Services.Concrete
{
    public class BasketService : IBasketService
    {
        private readonly IUnıtOfWork unıtOfWork;

        public BasketService(IUnıtOfWork unıtOfWork)
        {
            this.unıtOfWork = unıtOfWork;
        }

        public async Task<Basket> AddAsync(Basket entity)
        {
            await unıtOfWork.GetRepository<Basket>().AddAsync(entity);
            await unıtOfWork.SaveAsync();
            return entity;
        }

        public Task<bool> AnyAsync(Expression<Func<Basket, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ResultBasketDto>> BasketListByMenuTableWithProductName(int menuTableId)
        {
            var values = await unıtOfWork.GetRepository<Basket>().GetAllAsync(x => x.MenuTableID == menuTableId, x => x.Product);
            var result = values.Select(z => new ResultBasketDto
            {
                BasketID = z.BasketID,
                Count = z.Count,
                MenuTableID = z.MenuTableID,
                Price = z.Price,
                ProductID = z.ProductID,
                TotalPrice = z.TotalPrice,
                ProductName = z.Product.ProductName
            }).ToList();

            return result;
        }

        public Task<int> CountAsync(Expression<Func<Basket, bool>> predicate = null)
        {
            throw new NotImplementedException();
        }

        public async Task<Basket> DeleteAsync(Basket entity)
        {
            await unıtOfWork.GetRepository<Basket>().DeleteAsync(entity);
            await unıtOfWork.SaveAsync();
            return entity;
        }

        public async Task<List<Basket>> GetAllAsync(Expression<Func<Basket, bool>> predicate = null, params Expression<Func<Basket, object>>[] includeProperties)
        {
            return await unıtOfWork.GetRepository<Basket>().GetAllAsync(predicate, includeProperties);
        }

        public async Task<List<Basket>> GetAllAsync(params Expression<Func<Basket, object>>[] includeProperties)
        {
            return await unıtOfWork.GetRepository<Basket>().GetAllAsync(includeProperties);
        }

        public async Task<Basket> GetAsync(Expression<Func<Basket, bool>> predicate, params Expression<Func<Basket, object>>[] includeProperties)
        {
            return await unıtOfWork.GetRepository<Basket>().GetAsync(predicate, includeProperties);
        }

        public async Task<Basket> GetAsync(params Expression<Func<Basket, object>>[] includeProperties)
        {
            return await unıtOfWork.GetRepository<Basket>().GetAsync(includeProperties);
        }

        public async Task<Basket> GetByGuidAsync(Guid id)
        {
            return await unıtOfWork.GetRepository<Basket>().GetByGuidAsync(id);
        }

        public async Task<Basket> GetByIDAsync(int id)
        {
            return await unıtOfWork.GetRepository<Basket>().GetByIDAsync(id);
        }

        public async Task<List<Basket>> GetBasketByMenuTableNumber(int id)
        {
            var values = await unıtOfWork.GetRepository<Basket>().GetAllAsync(x => x.MenuTableID == id, x => x.Product);
            return values;
        }

        public async Task<Basket> UpdateAsync(Basket entity)
        {
            await unıtOfWork.GetRepository<Basket>().DeleteAsync(entity);
            await unıtOfWork.SaveAsync();
            return entity;
        }
    }
}
