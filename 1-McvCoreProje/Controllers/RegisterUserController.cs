using AMvcCoreProjeKampi.Models;
using BusinessLayer.Concrete;
using Data_AccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AMvcCoreProjeKampi.Controllers
{
    [AllowAnonymous]
    public class RegisterUserController : Controller
    {
        WriterManager wm = new WriterManager(new EfWriterDal());
        private readonly UserManager<AppUser> _userManager;

        public RegisterUserController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserSignUpViewModel p)
        {
            if (ModelState.IsValid)
            {
                AppUser user = new AppUser()
                {
                    Email = p.Mail,
                    UserName = p.UserName,
                    NameSurname = p.NameSurname
                    
                    
                };
                Writer w = new Writer();
                w.WriterMail = p.Mail;
                w.WriterName = p.UserName;
                w.WriterAbout = "Burayı Doldurunuz";
                w.WriterImage = "/CoreBlogTema/web/images/5.jpg";
                w.WriterPassword = p.Password;
                w.WriterStatus = true;
                wm.TAdd(w);
                var result = await _userManager.CreateAsync(user, p.Password);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Login");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);

                    }
                }

            }
            return View(p);
        }
    }
}
