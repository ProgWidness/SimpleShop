namespace SimpleShop.Data.Models
{
    public class ProductDto
    {
        public int Id { get; set; }
        public CategoryDto Category { get; set; }
        public BrandDto Brand { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Width { get; set; }
        public decimal Height { get; set; }
        public decimal Length { get; set; }
        public decimal Weight { get; set; }
        public decimal PowerConsumption { get; set; }
    }
}