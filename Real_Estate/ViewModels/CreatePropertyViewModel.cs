
using Real_Estate.Models;

namespace Real_Estate.ViewModels
{
    public class CreatePropertyViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string UrlImages { get; set; }
        public Double PriceifSale { get; set; }
        public Double PriceifRent { get; set; }
        public int? PropertyCategoryId { get; set; }
        public PropertyCategory? PropertyCategory { get; set; }
    }
}
