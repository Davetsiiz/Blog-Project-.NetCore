using Data_AccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace AMvcCoreProjeKampi.Areas.Admin.ViewComponenets.Statistic
{
    public class Statistic1:ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            Context c = new Context();
            ViewBag.v1 = c.blogs.Count().ToString();
            ViewBag.v2 = c.blogs.Where(x => x.WriterID == 1).Count().ToString();
            ViewBag.v3 = c.categories.Count().ToString();
            ViewBag.v4 = c.writers.Count().ToString();
            ViewBag.v5 = c.messages2.Count().ToString();
            ViewBag.v6 = c.comments.Count().ToString();


            string api = "f7602d7d084ca358a7a78b957f5d7d8c";
            string city = "istanbul";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q="+city+"&mode=xml&lang=tr&units=metric&appid="+api;
            XDocument document= XDocument.Load(connection);
            ViewBag.vt = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            return View();
        }
    }
}
