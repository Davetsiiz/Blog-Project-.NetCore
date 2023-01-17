using Data_AccessLayer.EntityFramework;
using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Data_AccessLayer.Concrete;

namespace AMvcCoreProjeKampi.ViewComponenets.Writer
{
    

    public class WriterAboutOnDashboard:ViewComponent
    {
        Context c = new Context();
        WriterManager wm = new WriterManager(new EfWriterDal());
        public IViewComponentResult Invoke()
        {
            var usermail = User.Identity.Name;
            var writerID = c.writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterID).FirstOrDefault();
            var values = wm.GetWritersByID(writerID);
            return View(values);
        }
    }
}
