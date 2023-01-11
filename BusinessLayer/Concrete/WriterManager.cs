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
    public class WriterManager : IWriterService
    {
        IWriterDal _writerDal;

        public WriterManager(IWriterDal writerDal)
        {
            _writerDal = writerDal;
        }

      

        public void WriterDelete(Writer writer)
        {
            _writerDal.Delete(writer);
        }

        public Writer WriterGetById(int id)
        {
            return _writerDal.GetById(id);
        }

        public void WriterInsert(Writer writer)
        {
            _writerDal.Insert(writer);
        }

        public void WriterUpdate(Writer writer)
        {
            _writerDal.Update(writer);  
        }

        List<Writer> IWriterService.WriterListAll()
        {
            return _writerDal.GetListAll();
        }
    }
}
