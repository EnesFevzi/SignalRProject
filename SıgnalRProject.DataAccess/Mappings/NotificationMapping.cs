using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SıgnalRProject.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SıgnalRProject.DataAccess.Mappings
{
    public class NotificationMapping : IEntityTypeConfiguration<Notification>
    {
        public void Configure(EntityTypeBuilder<Notification> builder)
        {
            builder.HasData(
                new Notification
                {
                    NotificationID = 1,
                    Type = "success",
                    Icon = "fa fa-check",
                    Description = "İşlem başarıyla tamamlandı.",
                    Date = DateTime.Now,
                    Status = true
                },
                new Notification
                {
                    NotificationID = 2,
                    Type = "warning",
                    Icon = "fa fa-exclamation-triangle",
                    Description = "Uyarı: Dikkatli olun!",
                    Date = DateTime.Now,
                    Status = true
                },
                new Notification
                {
                    NotificationID = 3,
                    Type = "danger",
                    Icon = "fa fa-times",
                    Description = "Hata: İşlem sırasında bir hata oluştu.",
                    Date = DateTime.Now,
                    Status = true
                }
            );
        }
    }
}
