using BusinessLayer.Concrete;
using Data_AccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AMvcCoreProjeKampi.Controllers
{
    public class MessageController : Controller
    {
        Message2Manager mm = new Message2Manager(new EfMessage2Dal());
        [AllowAnonymous]
        public IActionResult InBox()
        {
            int id = 1;

            var values = mm.GetInboxListByWriter(id);
            return View(values);
        }
    }
}
