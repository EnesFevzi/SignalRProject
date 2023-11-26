using AutoMapper;
using SıgnalRProject.Dto.AboutDto;
using SıgnalRProject.Dto.NotificationDto;
using SıgnalRProject.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SıgnalRProject.Service.AutoMapper
{
    internal class NotificationMapping : Profile
    {
        public NotificationMapping()
        {
            CreateMap<Notification, ResultNotificationDto>().ReverseMap();
           // CreateMap<Notification, CreateNotificationDto>().ReverseMap();
            CreateMap<Notification, GetAboutDto>().ReverseMap();
            CreateMap<Notification, UpdateNotificationDto>().ReverseMap();
        }
    }
}
