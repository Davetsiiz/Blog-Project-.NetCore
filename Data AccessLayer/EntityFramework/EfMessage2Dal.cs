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
    public class EfMessage2Dal:GenericRepositoryDal<Message2>, IMessage2Dal
    {
        public List<Message2> GetListWithMessageByWriter(int id)
        {
            using (var c = new Context())
            {
                return c.messages2.Include(b => b.SenderUser).Where(x => x.ReceiverID == id).ToList();
            }
        }

        public List<Message2> GetSendboxWithMessageByWriter(int id)
        {
            using (var c = new Context())
            {
                return c.messages2.Include(x => x.RecieverUser).Where(x => x.SenderID == id).ToList();
            }
        }
    }
}
