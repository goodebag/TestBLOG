using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestBlog.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string comments { get; set; }
        public int PostId { get; set; }
        public Post posts { get; set; }
        public string WhoCommented { get; set; }
       public DateTime DateAndtime { get; set; }
        public string CommenterSphotopath { get; set; }


    }
}
