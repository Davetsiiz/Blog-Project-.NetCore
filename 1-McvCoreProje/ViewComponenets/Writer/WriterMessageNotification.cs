using BusinessLayer.Concrete;
using Data_AccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AMvcCoreProjeKampi.ViewComponenets.Writer
{
    public class WriterMessageNotification : ViewComponent
    {
        Message2Manager mm = new Message2Manager(new EfMessage2Dal());
        public IViewComponentResult Invoke()
        {
            int id=1;
            
            var values = mm.GetInboxListByWriter(id);
            return View(values);
        }
    }
}

