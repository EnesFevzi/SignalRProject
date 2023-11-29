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
    public class MenuTableMapping : IEntityTypeConfiguration<MenuTable>
    {
        public void Configure(EntityTypeBuilder<MenuTable> builder)
        {
            builder.HasData(
                new MenuTable
                {
                    MenuTableID = 1,
                    Name = "Bahçe-01",
                    Status = false
                },
                new MenuTable
                {
                    MenuTableID = 2,
                    Name = "Bahçe-02",
                    Status = true
                },
                new MenuTable
                {
                    MenuTableID = 3,
                    Name = "Bahçe-03",
                    Status = true
                },
                new MenuTable
                {
                    MenuTableID = 4,
                    Name = "Bahçe-04",
                    Status = true
                },
                new MenuTable
                {
                    MenuTableID = 5,
                    Name = "Teras-01",
                    Status = true
                },
                 new MenuTable
                 {
                     MenuTableID = 6,
                     Name = "Teras-02",
                     Status = false
                 },
                  new MenuTable
                  {
                      MenuTableID = 7,
                      Name = "Teras-03",
                      Status = true
                  },
                   new MenuTable
                   {
                       MenuTableID = 8,
                       Name = "Teras-04",
                       Status = true
                   },
                new MenuTable
                {
                    MenuTableID = 9,
                    Name = "Salon-01",
                    Status = true
                },
                new MenuTable
                {
                    MenuTableID = 10,
                    Name = "Salon-02",
                    Status = false
                },
                new MenuTable
                {
                    MenuTableID = 11,
                    Name = "Salon-03",
                    Status = true
                },
                new MenuTable
                {
                    MenuTableID = 12,
                    Name = "Salon-04",
                    Status = true
                }

            );
        }
    }

}
