using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using Data_AccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace _1_McvCoreProje.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {

            var values = cm.CategoryListAll();
            return View(values);
        }
        public IActionResult DeleteCategory(int id)
        {
            var values = _categoryService.CategoryGetById(id);
            _categoryService.CategoryDelete(values);
            return RedirectToAction("Index");


        }
    }
}
