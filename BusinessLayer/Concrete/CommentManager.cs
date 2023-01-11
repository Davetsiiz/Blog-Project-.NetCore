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
    public class CommentManager : ICommentService
    {
        ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public Comment CommentGetById(int id)
        {
            return _commentDal.GetById(id);
        }

        public List<Comment> CommentListAll(int id)
        {
            return _commentDal.GetListAll(x=>x.BlogId==id);
        }

        public void CommentDelete(Comment comment)
        {
            _commentDal.Delete(comment);
        }

        public void CommentInsert(Comment comment)
        {
            _commentDal.Insert(comment);
        }

        public void CommentyUpdate(Comment comment)
        {
            _commentDal.Update(comment);
        }
    }
}
