using SıgnalRProject.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SıgnalRProject.Service.Services.Abstract
{
    public interface IDiscountService : IService<Discount>
    {
        Task ChangeStatusToTrue(int id);
        Task ChangeStatusToFalse(int id);
        Task<List<Discount>> GetListByStatusTrue();
    }
}
