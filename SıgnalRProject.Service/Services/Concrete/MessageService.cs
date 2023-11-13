using SıgnalRProject.DataAccess.UnıtOfWorks;
using SıgnalRProject.Entity.Entities;
using SıgnalRProject.Service.Services.Abstract;
using System.Linq.Expressions;

namespace SıgnalRProject.Service.Services.Concrete
{
    public class MessageService : IMessageService
    {
        private readonly IUnıtOfWork unıtOfWork;

        public MessageService(IUnıtOfWork unıtOfWork)
        {
            this.unıtOfWork = unıtOfWork;
        }
        public async Task AddAsync(Message entity)
        {
            await unıtOfWork.GetRepository<Message>().AddAsync(entity);
            await unıtOfWork.SaveAsync();
        }

        public Task<bool> AnyAsync(Expression<Func<Message, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<int> CountAsync(Expression<Func<Message, bool>> predicate = null)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(Message entity)
        {
            await unıtOfWork.GetRepository<Message>().DeleteAsync(entity);
            await unıtOfWork.SaveAsync();
        }

        public async Task<List<Message>> GetAllAsync(Expression<Func<Message, bool>> predicate = null, params Expression<Func<Message, object>>[] includeProperties)
        {
            return await unıtOfWork.GetRepository<Message>().GetAllAsync(predicate, includeProperties);
        }

        public async Task<List<Message>> GetAllAsync(params Expression<Func<Message, object>>[] includeProperties)
        {
            return await unıtOfWork.GetRepository<Message>().GetAllAsync(includeProperties);
        }

        public async Task<Message> GetAsync(Expression<Func<Message, bool>> predicate, params Expression<Func<Message, object>>[] includeProperties)
        {
            return await unıtOfWork.GetRepository<Message>().GetAsync(predicate, includeProperties);
        }

        public async Task<Message> GetAsync(params Expression<Func<Message, object>>[] includeProperties)
        {
            return await unıtOfWork.GetRepository<Message>().GetAsync(includeProperties);
        }

        public async Task<Message> GetByGuidAsync(Guid id)
        {
            return await unıtOfWork.GetRepository<Message>().GetByGuidAsync(id);
        }

        public async Task<Message> GetByIDAsync(int id)
        {
            return await unıtOfWork.GetRepository<Message>().GetByIDAsync(id);
        }

        public async Task UpdateAsync(Message entity)
        {
            await unıtOfWork.GetRepository<Message>().UpdateAsync(entity);
            await unıtOfWork.SaveAsync();
        }
    }
}
