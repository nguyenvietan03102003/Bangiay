using Bangiay.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bangiay.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        private readonly ILogger<HomeController> _logger;
        private readonly DataContext _context;

        public ContactController(ILogger<HomeController> logger, DataContext context)
        {
            _logger = logger;
            _context = context;
        }
    }
}
