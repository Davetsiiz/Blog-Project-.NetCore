using BusinessLayer.Concrete;
using Data_AccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace _1_McvCoreProje.Controllers
{
    public class CommentController : Controller
    {
        CommentManager cmm = new CommentManager(new EfCommentDal());
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult PartialAddComment() 
        {
            return PartialView();
        }
        [HttpPost]
		public PartialViewResult PartialAddComment(Comment p)
		{
            p.CommentDate=DateTime.Parse(DateTime.Now.ToShortDateString());
            p.CommentStatus = true;
            p.BlogId = 4;
            cmm.CommentInsert(p);
			return PartialView();
		}
		public PartialViewResult CommentListByBlog(int id) 
        {
            var values=cmm.CommentListAll(id);
            return PartialView(values);
        }
    }
}
