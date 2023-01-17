using AMvcCoreProjeKampi.Models.ViewModel;
using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using Data_AccessLayer.Concrete;
using Data_AccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace _1_McvCoreProje.Controllers
{
    [AllowAnonymous]
    public class BlogController : Controller
        
    {
        BlogManager bm = new BlogManager(new EfBlogDal());
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        Context c = new Context();
        public IActionResult Index()
        {
            var values=bm.GetBlogListWithCategory();
            return View(values);
        }
        public IActionResult BlogReadAll(int id)
        {
            ViewBag.i = id;
            var values=bm.GetBlogByID(id);
            return View(values);
        }

        public IActionResult BlogListByWriter()
        {
            var usermail = User.Identity.Name;
            var writerID = c.writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterID).FirstOrDefault();
            var values=bm.GetListWithCategoryByWriterBm(writerID);
            return View(values);

        }
        [HttpGet]
        public IActionResult BlogAdd()
        {   
            List<SelectListItem> categoryvalue = (from x in cm.GetList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.CategoryName,
                                                      Value = x.CategoryId.ToString()
                                                  }).ToList();
            ViewBag.cv=categoryvalue;
            return View();
        }

        [HttpPost]
        public IActionResult BlogAdd(Blog p)
        {
            var usermail = User.Identity.Name;
            var writerID = c.writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterID).FirstOrDefault();
            BlogValidator bv= new BlogValidator();
            ValidationResult results= bv.Validate(p);
            List<SelectListItem> categoryvalue = (from x in cm.GetList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.CategoryName,
                                                      Value = x.CategoryId.ToString()
                                                  }).ToList();
            ViewBag.cv = categoryvalue;
            if (results.IsValid)
            {
                p.BlogTumbnailImage = "Yok";
                p.BlogDate = DateTime.Parse(DateTime.Now.ToString());
                p.BlogStatus = true;
                p.WriterID = writerID;
                
                bm.TAdd(p);
                return RedirectToAction("BlogListByWriter", "Blog");
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
        public IActionResult BlogDelete(int id)
        {
            var blogvalue=bm.TGetById(id);
            bm.TDelete(blogvalue);
            return RedirectToAction("BlogListByWriter");
        }
        [HttpGet]
        public IActionResult BlogEdit(int id)
        {
            List<SelectListItem> categoryvalue = (from x in cm.GetList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.CategoryName,
                                                      Value = x.CategoryId.ToString()
                                                  }).ToList();
            ViewBag.cv = categoryvalue;
            var blogvalue=bm.TGetById(id);
            return View(blogvalue);
        }
        [HttpPost]
        public IActionResult BlogEdit(Blog p,int id)
        {
            var usermail = User.Identity.Name;
            var writerID = c.writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterID).FirstOrDefault();
            var blogvalue = bm.TGetById(id);
            p.WriterID = writerID; 
            p.BlogStatus = true;
            p.BlogDate = blogvalue.BlogDate;
            bm.TUpdate(p);
            return RedirectToAction("BlogListByWriter");
        }
    }
}
