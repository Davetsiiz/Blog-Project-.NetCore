using Data_AccessLayer.EntityFramework;
using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Data_AccessLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using EntityLayer.Concrete;

namespace AMvcCoreProjeKampi.ViewComponenets.Writer
{
    

    public class WriterAboutOnDashboard:ViewComponent
    {

		WriterManager wm = new WriterManager(new EfWriterDal());
		Context c = new Context();
		public IViewComponentResult Invoke()
		{
			var username = User.Identity.Name;
			ViewBag.veri = username;
			var usermail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
			var writerID = c.writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterID).FirstOrDefault();
			var values = wm.GetWritersByID(writerID);
			return View(values);
		}
	}
}
