using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SıgnalRProject.Entity.Entities;

namespace SıgnalRProject.DataAccess.Mappings
{
    public class ProductMapping : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
            new Product
            {
                ProductID = 1,
                ProductName = "Classic Burger",
                Description = "Lezzetli bir classic burger",
                Price = 20.99m,
                ImageUrl = "/images/burger-images/burger.jpg",
                CategoryID = 1
            },
            new Product
            {
                ProductID = 2,
                ProductName = "Double Cheeseburger",
                Description = "İki katlı lezzetli bir cheeseburger",
                Price = 25.99m,
                ImageUrl = "/images/burger-images/double-cheeseburger.jpg",
                CategoryID = 1
            },
             new Product
             {
                 ProductID = 6,
                 ProductName = "Bacon Avocado Burger",
                 Description = "Bacon ve avokado ile zenginleştirilmiş burger",
                 Price = 23.50m,
                 ImageUrl = "/images/burger-images/bacon-avocado-burger.jpg",
                 CategoryID = 1
             },
             new Product
             {
                 ProductID = 4,
                 ProductName = "Mushroom Swiss Burger",
                 Description = "Mantar ve Swiss peyniri ile lezzetlendirilmiş burger",
                 Price = 21.75m,
                 ImageUrl = "/images/burger-images/mushroom-swiss-burger.jpg",
                 CategoryID = 1
             },
             new Product
             {
                 ProductID = 5,
                 ProductName = "BBQ Ranch Burger",
                 Description = "Barbekü sosu ve ranch soslu nefis bir burger",
                 Price = 22.99m,
                 ImageUrl = "/images/burger-images/bbq-ranch-burger.jpg",
                 CategoryID = 1
             },
             new Product
             {
                 ProductID = 3,
                 ProductName = "Vegan Beyond Burger",
                 Description = "Vegan ve et içermeyen bir lezzet deneyimi",
                 Price = 19.50m,
                 ImageUrl = "/images/burger-images/vegan-beyond-burger.jpg",
                 CategoryID = 1
             },
            new Product
            {
                ProductID = 7,
                ProductName = "Spaghetti Bolognese",
                Description = "İtalyan usulü kıymalı makarna",
                Price = 18.50m,
                ImageUrl = "/images/makarna-images/spaghetti.jpg",
                CategoryID = 2
            },
            new Product
            {
                ProductID = 8,
                ProductName = "Cobb Salata",
                Description = "Lezzetli bir Cobb salata",
                Price = 12.75m,
                ImageUrl = "/images/salata-images/cobb-salad.jpg",
                CategoryID = 3
            },
            new Product
            {
                ProductID = 9,
                ProductName = "Cola",
                Description = "Soğuk ve serinletici kola",
                Price = 3.99m,
                ImageUrl = "/images/icecek-images/cola.png",
                CategoryID = 4
            },
            new Product
            {
                ProductID = 10,
                ProductName = "Margarita Pizza",
                Description = "Sade ve lezzetli bir margarita pizza",
                Price = 22.50m,
                ImageUrl = "/images/pizza-images/margarita-pizza.png",
                CategoryID = 5
            },
            new Product
            {
                ProductID = 11,
                ProductName = "Chicken Alfredo Pasta",
                Description = "Tavuklu Alfredo makarna",
                Price = 24.99m,
                ImageUrl = "/images/makarna-images/chicken-alfredo-pasta.jpg",
                CategoryID = 2
            },
            new Product
            {
                ProductID = 12,
                ProductName = "Lemonade",
                Description = "Taze limonata içimi",
                Price = 5.99m,
                ImageUrl = "/images/icecek-images/lemonade.jpg",
                CategoryID = 4
            },
            new Product
            {
                ProductID = 13,
                ProductName = "Pepperoni Pizza",
                Description = "Pepperoni ile zenginleştirilmiş pizza",
                Price = 23.25m,
                ImageUrl = "/images/pizza-images/pepperoni-pizza.jpg",
                CategoryID = 5
            },
            new Product
            {
                ProductID = 14,
                ProductName = "Shrimp Scampi",
                Description = "Karidesli İtalyan makarna",
                Price = 27.50m,
                ImageUrl = "/images/makarna-images/shrimp-scampi.jpg",
                CategoryID = 2
            }
                );
        }
    }
}
