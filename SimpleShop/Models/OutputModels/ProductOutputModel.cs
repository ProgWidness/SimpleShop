namespace SimpleShop.Models.OutputModels
{
    public class ProductOutputModel
    {
        public int Id { get; set; }

        public CategoryOutpuModel Category { get; set; }

        public BrandOutputModel Brand { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public decimal Width { get; set; }

        public decimal Height { get; set; }

        public decimal Length { get; set; }

        public decimal Weight { get; set; }

        public decimal PowerConsumption { get; set; }
    }
}