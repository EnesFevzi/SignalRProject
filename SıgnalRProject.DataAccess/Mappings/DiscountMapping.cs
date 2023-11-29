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
    public class DiscountMapping : IEntityTypeConfiguration<Discount>
    {
        public void Configure(EntityTypeBuilder<Discount> builder)
        {
            builder.HasData(
                new Discount
                {
                    DiscountID = 1,
                    Title = "İlk İndirim",
                    Amount = "20", 
                    Description = "Açılışa Özel İndirim",
                    ImageUrl = "/images/discount-images/yüzde20.png",
                    Status = true 
                },
                new Discount
                {
                    DiscountID = 2,
                    Title = "Öğrenciye Özel İndirim",
                    Amount = "10", 
                    Description = "Öğrenci Kartınızı yetkiliye gösterin %10 indirim kazanın.",
                    ImageUrl = "/images/discount-images/yüzde10.png",
                    Status = true 
                }
            );
        }
    }
}
