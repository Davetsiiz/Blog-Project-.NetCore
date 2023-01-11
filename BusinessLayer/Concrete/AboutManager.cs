using BusinessLayer.Abstract;
using Data_AccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void AboutDelete(About about)
        {
           _aboutDal.Delete(about);
        }

        public About AboutGetById(int id)
        {
           return _aboutDal.GetById(id);
        }

        public void AboutInsert(About about)
        {
            _aboutDal.Insert(about);
        }

        public void AboutUpdate(About about)
        {
            _aboutDal.Update(about);
        }

        public List<About> GetList()
        {
            return _aboutDal.GetListAll();
        }
    }
}
