using Microsoft.AspNetCore.Mvc;

namespace AMvcCoreProjeKampi.ViewComponenets.Writer
{
    public class WriterMessageNotification : ViewComponent
    {
        public IViewComponentResult Invoke()
        {

           
            return View();
        }
    }
}

