using System.ComponentModel.DataAnnotations;

namespace SimpleShop.Models.InputModels
{
    public class ProductInputModel
    {
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public int BrandId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public decimal Width { get; set; }
        [Required]
        public decimal Height { get; set; }
        [Required]
        public decimal Length { get; set; }
        [Required]
        public decimal Weight { get; set; }
        [Required]
        public decimal PowerConsumption { get; set; }
    }
}