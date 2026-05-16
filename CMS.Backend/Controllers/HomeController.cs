using CMS.Backend.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CMS.Backend.Controllers
{
    // Controller m?c ??nh c?a trang ch?
    public class HomeController : Controller
    {
        // Bi?n ghi log cho HomeController
        private readonly ILogger<HomeController> _logger;

        // Hàm kh?i t?o, nh?n logger t? h? th?ng
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // Action hi?n th? trang ch?
        public IActionResult Index()
        {
            return View();
        }

        // Action hi?n th? trang Privacy
        public IActionResult Privacy()
        {
            return View();
        }

        // Action x? lý trang l?i
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}