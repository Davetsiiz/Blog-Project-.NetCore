using Data_AccessLayer.Abstract;
using Data_AccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_AccessLayer.EntityFramework
{
    public class EfBlogDal : GenericRepositoryDal<Blog>, IBlogDal
    {
        public List<Blog> GetListWithCategory()
        {
            using(var c=new Context()) 
            { 
                return  c.blogs.Include(b => b.Category).ToList();
             }
            
        }
    }
}
