using BusinessLayer.Concrete;
using Data_AccessLayer.Concrete;
using Data_AccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AMvcCoreProjeKampi.Areas.Admin.ViewComponenets.Statistic
{
    public class Statistic2 : ViewComponent
    {
        //ContactManager cm = new ContactManager(new EfContactDal());
        BlogManager bm = new BlogManager(new EfBlogDal());
        public IViewComponentResult Invoke()
        {

            Context c = new Context();
            ViewBag.c1 = c.contacts.Select(x => x.ContactSubject).FirstOrDefault();
            ViewBag.c2 = c.contacts.Select(x => x.ContactMessage).FirstOrDefault();
            ViewBag.c3 = c.contacts.Select(x => x.ContactUserName).FirstOrDefault();
            //var value = cm.ContactGetById(1);
            //ViewBag.con1 = value.ContactSubject;
            //ViewBag.con2 = value.ContactMessage;
            //ViewBag.con3 = value.ContactUserName;

            //var valueblog = bm.GetList();
            //ViewBag.bl1 = valueblog.Last().BlogTitle;
            //ViewBag.bl2 = valueblog.Last().writers.WriterName;
            //ViewBag.bl3 = valueblog.Last().BlogDate.ToShortDateString();
            ViewBag.b1 = c.blogs.OrderByDescending(x=>x.BlogId).Select(x => x.BlogTitle).Take(1).FirstOrDefault();
            ViewBag.b2 = c.blogs.OrderByDescending(x => x.BlogId).Select(x => x.BlogDate.ToShortDateString()).Take(1).FirstOrDefault();
            int valu = c.blogs.OrderByDescending(x => x.BlogId).Select(x => x.WriterID).Take(1).FirstOrDefault();

            ViewBag.b3 = c.writers.Where(x => x.WriterID == valu).Select(y => y.WriterName).FirstOrDefault();

            return View();
        }
    }
}
