using SıgnalRProject.Entity.Entities;
using SıgnalRProject.WebUI.DTOs.CategoriesDto;

namespace SıgnalRProject.WebUI.DTOs.ProductDto
{
    public class ResultProductDto
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public bool ProductStatus { get; set; }
        public ResultCategoryDto Category { get; set; }
    }
}
