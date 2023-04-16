using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Real_Estate.Models
{
    public class EstateProperty
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string UrlImages { get; set; }
        public Double PriceifSale { get; set; }
        public Double PriceifRent { get; set; }
        public List<Appointment>? Appointments { get; set; }
        public List<PropertyListViewModel>? PropertyListViews { get; set; }
        public int? PropertyCategoryId { get; set; }
        public PropertyCategory? PropertyCategory { get; set; }
        //relationships
        public string ApplicationUserId { get; set; }
        public ApplicationUser? ApplicationUser { get; set; }    
    }
}
