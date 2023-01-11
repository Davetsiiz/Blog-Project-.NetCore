using BusinessLayer.Abstract;
using Data_AccessLayer.Abstract;
using Data_AccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class CategoryManager : ICategoryService
	{
		ICategoryDal _categorDal;

		
		public CategoryManager(ICategoryDal categorDal)
		{
			_categorDal = categorDal;
		}

		public void CategoryDelete(Category category)
		{
			_categorDal.Delete(category);
		}

		public Category CategoryGetById(int id)
		{
			return _categorDal.GetById(id);
		}

		public void CategoryInsert(Category category)
		{
			_categorDal.Insert(category);
		}

		public List<Category> CategoryListAll()
		{
			return _categorDal.GetListAll();
		}

		public void CategoryUpdate(Category category)
		{
			_categorDal.Update(category);
		}
	}
}
