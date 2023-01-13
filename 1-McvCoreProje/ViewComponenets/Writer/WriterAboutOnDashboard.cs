using Data_AccessLayer.EntityFramework;
using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AMvcCoreProjeKampi.ViewComponenets.Writer
{
    

    public class WriterAboutOnDashboard:ViewComponent
    {
        WriterManager wm = new WriterManager(new EfWriterDal());
        public IViewComponentResult Invoke()
        {
            var values = wm.GetWritersByID(1);
            return View(values);
        }
    }
}
