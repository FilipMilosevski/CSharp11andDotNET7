using Microsoft.AspNetCore.Mvc;
using Ogani.Data;
using Ogani.Data.Entities;

namespace Ogani.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ConsoleController : Controller
    {
        private readonly ApplicationDbContext _db;
        public ConsoleController(ApplicationDbContext dbContext)
        {
            _db = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Products()
        {
            List<Product> products = _db.Products.ToList();
            return View(products);
        
        }       
    }
}
