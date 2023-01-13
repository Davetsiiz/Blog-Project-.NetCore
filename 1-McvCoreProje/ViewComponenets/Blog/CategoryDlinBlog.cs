using AMvcCoreProjeKampi.Models.ViewModel;
using BusinessLayer.Concrete;
using Data_AccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AMvcCoreProjeKampi.ViewComponenets.Blog
{

    public class CategoryDlinBlog : ViewComponent 
    { 
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        [HttpGet]
        public IViewComponentResult Invoke()
        {
            var CategoryValue = cm.GetList();
            var model = new CategoryDLinBlog();
            model.CategorySelectList = new List<SelectListItem>();
            foreach (var category in CategoryValue)
            {
                model.CategorySelectList.Add(new SelectListItem { Text = category.CategoryName, Value = category.CategoryId.ToString() });
            }

            return View(model);
        }
        //[HttpPost]
        //public IViewComponentResult Invoke(CategoryDLinBlog model)
        //{
        //    TempData["CId"] = model.SelcetedCategory;
        //    return ActionModel("BlogAdd", "Blog");
        //}

    }
}
