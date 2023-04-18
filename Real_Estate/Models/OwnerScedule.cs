using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Real_Estate.Models
{
    public class OwnerScedule
    {
        public int Id { get; set; }
        public string OwnerId { get; set; }
        public ApplicationUser User { get; set; }
        [Required]
        public string dayOfWeek { get; set; }
        [BindProperty, DataType(DataType.Time)]
        [Required]
        public DateTime? startTime { get; set; }
        [BindProperty, DataType(DataType.Time)]
        [Required]
        public DateTime? endTime { get; set; }
    }
}
