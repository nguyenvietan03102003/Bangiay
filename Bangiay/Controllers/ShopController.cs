using Bangiay.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bangiay.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            var mnList = _context.Products.OrderBy(m => m.ProductID).ToList();
            return View(mnList);
        }
        [Route("/product-{slug}-{id:int}.html", Name = "product")]
        public IActionResult Details_product(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var product = _context.Products
                .FirstOrDefault(m => (m.ProductID == id) && (m.IsActive == true));
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        private readonly ILogger<HomeController> _logger;
        private readonly DataContext _context;

        public ShopController(ILogger<HomeController> logger, DataContext context)
        {
            _logger = logger;
            _context = context;
        }
    }
}
