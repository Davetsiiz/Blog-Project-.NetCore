using BusinessLayer.Concrete;
using Data_AccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AMvcCoreProjeKampi.ViewComponenets.Comment
{
	public class CommentListByBlog : ViewComponent
	{
		CommentManager cm = new CommentManager(new EfCommentDal());
		public IViewComponentResult Invoke(int id)
		{
			
			var values = cm.CommentListAll(id);
			return View(values);
		}
	}
}
