using Bangiay.Utilities;
using Microsoft.AspNetCore.Mvc;

namespace Bangiay.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
      
            return View();
        }
        public IActionResult Logout()
        {
            Functions._UserID = 0;
            Functions._UserName = string.Empty;
            Functions._Email = string.Empty;
            Functions._Message = string.Empty;
            Functions._MessageEmail = string.Empty;

            return RedirectToAction("Index", "Home");
        }
    }
}
