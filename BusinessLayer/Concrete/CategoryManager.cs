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
        public Category TGetById(int id)
        {
            return _categorDal.GetById(id);
        }

        public List<Category> GetList()
        {
            return _categorDal.GetListAll();
        }

        public void TAdd(Category t)
        {
            _categorDal.Insert(t);
        }

        public void TDelete(Category t)
        {
            _categorDal.Delete(t);
        }

        public void TUpdate(Category t)
        {
           _categorDal.Update(t);
        }
    }
}
