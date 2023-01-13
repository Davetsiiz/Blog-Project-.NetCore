using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Comment
    {
        [Key]
        public int CommentID { get; set; }
        public String CommentUserName { get; set; }
        public String CommentTitle { get; set; }
        public String CommentContent { get; set; }
        public DateTime CommentDate { get; set; }

        public int BlogScore { get; set; }
        public bool CommentStatus { get; set; }

        //
        public int BlogId { get; set; }
        public Blog Blogs { get; set; }
    }
}
