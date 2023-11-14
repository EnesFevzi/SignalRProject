using SıgnalRProject.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SıgnalRProject.Service.Services.Abstract
{
    public interface IBookingService : IService<Booking>
    {
        Task BookingStatusApproved(int id);
        Task BookingStatusCancelled(int id);
    }
}
