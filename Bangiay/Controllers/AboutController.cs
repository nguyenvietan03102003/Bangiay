using Bangiay.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bangiay.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        private readonly ILogger<HomeController> _logger;
        private readonly DataContext _context;

        public AboutController(ILogger<HomeController> logger, DataContext context)
        {
            _logger = logger;
            _context = context;
        }
    }
}