using BusinessLayer.Concrete;
using Data_AccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AMvcCoreProjeKampi.ViewComponenets.Blog
{
    public class BlogListDashboard:ViewComponent
    {

        BlogManager bm = new BlogManager(new EfBlogDal());
        public IViewComponentResult Invoke()
        {
            var values = bm.GetBlogListWithCategory();
            return View(values);
        }

    }
}
