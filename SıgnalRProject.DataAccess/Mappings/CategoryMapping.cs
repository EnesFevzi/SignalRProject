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
    public class CategoryMapping : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
           new Category { CategoryID = 1, CategoryName = "Hamburgerler" },
           new Category { CategoryID = 2, CategoryName = "Makarnalar" },
           new Category { CategoryID = 3, CategoryName = "Salatalar" },
           new Category { CategoryID = 4, CategoryName = "İçecekler" },
           new Category { CategoryID = 5, CategoryName = "Pizzalar" });
        }
    }
}
