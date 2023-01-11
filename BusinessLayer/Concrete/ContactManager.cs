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
    public class ContactManager : IContactService
    {
        IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public List<Contact> GetList()
        {
            return _contactDal.GetListAll();
        }

        public void ContactDelete(Contact contact)
        {
            _contactDal.Delete(contact);
        }

        public Contact ContactGetById(int id)
        {
            return _contactDal.GetById(id);
        }

        public void ContactInsert(Contact contact)
        {
            _contactDal.Insert(contact);
        }

        public void ContactUpdate(Contact contact)
        {
            _contactDal.Update(contact);
        }
    }
}
