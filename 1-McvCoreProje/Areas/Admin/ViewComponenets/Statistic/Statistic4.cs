using Data_AccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AMvcCoreProjeKampi.Areas.Admin.ViewComponenets.Statistic
{
    public class Statistic4:ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.a1=c.admins.Where(x=>x.AdminID==1).Select(y=>y.Name).SingleOrDefault();
            ViewBag.a2=c.admins.Where(x=>x.AdminID==1).Select(y=>y.ImageUrl).SingleOrDefault();
            ViewBag.a3=c.admins.Where(x=>x.AdminID==1).Select(y=>y.ShortDescription).SingleOrDefault();

            return View();
        }
    }
}
