using BusinessLayer.Abstract;
using Data_AccessLayer.Abstract;
using Data_AccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class BlogManager : IBlogService
	{
		IBlogDal _blogDal;

		public BlogManager(IBlogDal blogDal)
		{
			_blogDal = blogDal;
		}
		public void BlogDelete(Blog blog)
		{
			_blogDal.Delete(blog);
		}

		public void BlogInsert(Blog blog)
		{
			_blogDal.Insert(blog);
		}

		public void BlogUpdate(Blog blog)
		{
			_blogDal.Update(blog);
		}

        public List<Blog> GetBlogListWithCategory()
        {
            return _blogDal.GetListWithCategory();
        }

        public Blog GetById(int id)
		{
			return _blogDal.GetById(id);
		}

		public List<Blog> GetListAll()
		{
			return _blogDal.GetListAll();
		}
		public List<Blog> GetLast3Blog()
		{
			return _blogDal.GetListAll().TakeLast(3).ToList();
		}
		public List<Blog> GetBlogByID(int id)
		{
			return _blogDal.GetListAll(x=>x.BlogId==id);
		}

		public List<Blog> GetBlogListByWriter(int id)
		{
			return _blogDal.GetListAll(x=>x.WriterID==id);
		}
	}
}
