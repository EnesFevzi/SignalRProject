using SıgnalRProject.DataAccess.Context;
using SıgnalRProject.DataAccess.Repositories.Abstract;
using SıgnalRProject.DataAccess.Repositories.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SıgnalRProject.DataAccess.UnıtOfWorks
{
    public class UnitOfWork : IUnıtOfWork
    {
        private readonly SıgnalRContext _dbContext;

        public UnitOfWork(SıgnalRContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async ValueTask DisposeAsync()
        {
            await _dbContext.DisposeAsync();
        }

        public int Save()
        {
            return _dbContext.SaveChanges();
        }

        public async Task<int> SaveAsync()
        {
            return await _dbContext.SaveChangesAsync();
        }


        IRepository<T> IUnıtOfWork.GetRepository<T>()
        {
            return new Repository<T>(_dbContext);
        }
    }
}
