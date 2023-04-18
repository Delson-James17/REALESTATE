using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Real_Estate.Models
{
    public class Appointment
    {
        [Key]
        [Required]
        public int Id { get; set; } // filter id
     //   public string? TO { get; set; }
        [Required]
        [DisplayName("Full Name")]
        public string Name { get; set; }
        [Required]
        [DisplayName("Email")]
        public string? Email {get; set; }
        [Required]

        [RegularExpression("^(09|\\+639)\\d{9}$", ErrorMessage = "Invalid phone number.")]
        public string? Phone { get; set; }
        [Required]
        [DisplayName("Address")]
        public string? Address { get; set; }
      
        //public string Password { get; set; }
        public int? PropertyId { get; set; }
        public EstateProperty? Property { get; set; }
       [DataType(DataType.DateTime)]
        [Required]
        public DateTime? DateofAppointment { get; set; }
       
       
      
    }
}
