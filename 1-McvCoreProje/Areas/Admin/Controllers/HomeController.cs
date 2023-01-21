using Microsoft.AspNetCore.Mvc;

namespace AMvcCoreProjeKampi.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
