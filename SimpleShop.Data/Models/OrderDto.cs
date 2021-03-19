using System.Collections.Generic;

namespace SimpleShop.Data.Models
{
    public class OrderDto
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public ClientDto Client { get; set; }
        public Dictionary<ProductDto, int> Products { get; set; }
    }
}