using Microsoft.AspNetCore.Mvc;

namespace CMS.Backend.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
