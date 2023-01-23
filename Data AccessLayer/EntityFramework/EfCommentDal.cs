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
    public class EfCommentDal:GenericRepositoryDal<Comment>,ICommentDal
    {
        public List<Comment> GetListWithBlog()
        {
            using (var c = new Context())
            {
                return c.comments.Include(x => x.Blogs).ToList();
            }
        }
    }
}
