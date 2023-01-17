using BusinessLayer.Concrete;
using Data_AccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

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

        [AllowAnonymous]
        public IActionResult MessageDetails(int id)
        {
            
            var values = mm.TGetById(id);
            return View(values);
        }
    }
}
