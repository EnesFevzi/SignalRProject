using SıgnalRProject.DataAccess.UnıtOfWorks;
using SıgnalRProject.Entity.Entities;
using SıgnalRProject.Service.Services.Abstract;
using System.Linq.Expressions;


namespace SıgnalRProject.Service.Services.Concrete
{
    public class ContactService : IContactService
    {
        private readonly IUnıtOfWork unıtOfWork;

        public ContactService(IUnıtOfWork unıtOfWork)
        {
            this.unıtOfWork = unıtOfWork;
        }
        public async Task AddAsync(Contact entity)
        {
            await unıtOfWork.GetRepository<Contact>().AddAsync(entity);
            await unıtOfWork.SaveAsync();
        }

        public Task<bool> AnyAsync(Expression<Func<Contact, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<int> CountAsync(Expression<Func<Contact, bool>> predicate = null)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(Contact entity)
        {
            await unıtOfWork.GetRepository<Contact>().DeleteAsync(entity);
            await unıtOfWork.SaveAsync();
        }

        public async Task<List<Contact>> GetAllAsync(Expression<Func<Contact, bool>> predicate = null, params Expression<Func<Contact, object>>[] includeProperties)
        {
            return await unıtOfWork.GetRepository<Contact>().GetAllAsync(predicate, includeProperties);
        }

        public async Task<List<Contact>> GetAllAsync(params Expression<Func<Contact, object>>[] includeProperties)
        {
            return await unıtOfWork.GetRepository<Contact>().GetAllAsync(includeProperties);
        }

        public async Task<Contact> GetAsync(Expression<Func<Contact, bool>> predicate, params Expression<Func<Contact, object>>[] includeProperties)
        {
            return await unıtOfWork.GetRepository<Contact>().GetAsync(predicate, includeProperties);
        }

        public async Task<Contact> GetAsync(params Expression<Func<Contact, object>>[] includeProperties)
        {
            return await unıtOfWork.GetRepository<Contact>().GetAsync(includeProperties);
        }

        public async Task<Contact> GetByGuidAsync(Guid id)
        {
            return await unıtOfWork.GetRepository<Contact>().GetByGuidAsync(id);
        }

        public async Task<Contact> GetByIDAsync(int id)
        {
            return await unıtOfWork.GetRepository<Contact>().GetByIDAsync(id);
        }

        public  async Task UpdateAsync(Contact entity)
        {
            await unıtOfWork.GetRepository<Contact>().UpdateAsync(entity);
            await unıtOfWork.SaveAsync();
        }
    }
}
