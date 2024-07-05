using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApp5ByPrameshwor.Models;


namespace WebApp5ByPrameshwor.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly DbFirstContext _context;

        public EmployeeController(DbFirstContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Employees.ToList());
        }
    }
}
