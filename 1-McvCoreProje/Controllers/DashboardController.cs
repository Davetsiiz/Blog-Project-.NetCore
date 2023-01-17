using Data_AccessLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AMvcCoreProjeKampi.Controllers
{
    public class DashboardController : Controller
    {
        
        public IActionResult Index()
        {
            Context c = new Context();
            ViewBag.v1=c.blogs.Count().ToString();
            ViewBag.v2=c.blogs.Where(x=>x.WriterID==1).Count().ToString();
            ViewBag.v3 = c.categories.Count().ToString();
            ViewBag.v4=c.writers.Count().ToString();
            return View();
        }
    }
}
