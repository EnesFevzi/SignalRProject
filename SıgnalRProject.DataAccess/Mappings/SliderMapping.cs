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
    public class SliderMapping : IEntityTypeConfiguration<Slider>
    {
        public void Configure(EntityTypeBuilder<Slider> builder)
        {
            builder.HasData(
             new Slider
             {
                 SliderID = 1,
                 Title1 = "İtalyan Pizzalar",
                 Description1 = "En lezzetli İtalyan pizzaları ile tanışın!",
                 Title2 = "Sağlıklı Salatalar",
                 Description2 = "Sağlığınız için özenle hazırlanan sağlıklı salatalarımızı deneyin!",
                 Title3 = "Tatlı Molası",
                 Description3 = "Lezzetli tatlılarımızla tatlı bir mola verin!",

             }
                         );
        }
    }
}
