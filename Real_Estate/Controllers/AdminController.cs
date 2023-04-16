using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Real_Estate.Data;

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
    }
}
