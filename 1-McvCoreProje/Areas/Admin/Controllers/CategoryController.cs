using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using Data_AccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.AspNetCore;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using X.PagedList;

namespace AMvcCoreProjeKampi.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin, Moderator")]
    public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        
        public IActionResult Index(int page=1)
        {
            //ilk hangi sayfadan başlayacak, ikinci bir sayfada kaç tane listeyeceksin
            var values = cm.GetList().ToPagedList(page,4);
            return View(values);
        }

      
        [HttpGet]
        public IActionResult CategoryAdd() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult CategoryAdd(Category p)
        {
            CategoryValidator cv = new CategoryValidator();
            ValidationResult results = cv.Validate(p);
            if (results.IsValid)
            {
                p.CategoryStatus = true;
                cm.TAdd(p);
                return RedirectToAction("Index", "Category");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        public IActionResult CategoryPasif(int id)
        {
            var value=cm.TGetById(id);
            value.CategoryStatus = false;
            cm.TUpdate(value);
            return RedirectToAction("Index", "Category");
        }
        public IActionResult CategoryActive(int id)
        {
            var value = cm.TGetById(id);
            value.CategoryStatus = true;
            cm.TUpdate(value);
            return RedirectToAction("Index", "Category");
        }
    }
}
