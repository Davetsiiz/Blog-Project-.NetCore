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
			var username = User.Identity.Name;
			var usermail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
			var writerid = c.writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterID).FirstOrDefault();
			ViewBag.v1=c.blogs.Count().ToString();
            ViewBag.v2=c.blogs.Where(x=>x.WriterID==writerid).Count().ToString();
            ViewBag.v3 = c.categories.Count().ToString();
            ViewBag.v4=c.writers.Count().ToString();
            return View();
        }
    }
}
