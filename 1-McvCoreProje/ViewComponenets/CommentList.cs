using _1_McvCoreProje.Models;
using Microsoft.AspNetCore.Mvc;

namespace _1_McvCoreProje.ViewComponenets
{
	public class CommentList:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var commentlist = new List<UserComment>
			{
				new UserComment
				{
					ID= 1,
					UserName="Murat"
				} ,
				new UserComment
				{
					ID= 2,
					UserName="Eren"
				},
				new UserComment
				{
					ID= 3,
					UserName="Emre"
				}
			};
			return View(commentlist);
		}
	}
}
