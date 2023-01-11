using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using Data_AccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace AMvcCoreProjeKampi.Controllers
{
	public class RegisterController : Controller
	{
		WriterManager wm = new WriterManager(new EfWriterDal());

		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}


		[HttpPost]
		public IActionResult Index(Writer p)
		{
			WriterValidator wv=new WriterValidator();
			ValidationResult results=wv.Validate(p);
			if (results.IsValid) 
			{
                p.WriterStatus = true;
                p.WriterAbout = "Deneme ve Test";
                wm.WriterInsert(p);
                return RedirectToAction("Index", "Blog");
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
	}
}
