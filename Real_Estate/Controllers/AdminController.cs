using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Real_Estate.Data;
using Real_Estate.ViewModels;

namespace Real_Estate.Controllers
{
    public class AdminController :Controller
    {
        private readonly RealEDbContext _context;

        public AdminController(RealEDbContext context)
        {
            _context = context;
        }
        public IActionResult AdminPannel()
        {
            return View();
        }
        public IActionResult RowCount()
        {
            var model = new RowCountViewModel
            {
                PropertyCount = _context.EstateProperties.Count(),
                AppointmentCount = _context.Appointments.Count(),
                UserCount = _context.ApplicationUsers.Count()
            };

            return View(model);
        }
    }
}
