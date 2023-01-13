using BusinessLayer.Concrete;
using Data_AccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AMvcCoreProjeKampi.ViewComponenets.Category
{
    public class CategoryListDashboard:ViewComponent
    {
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        public IViewComponentResult Invoke()
        {
            var values = cm.GetList();
            return View(values);
        }

    }
}
