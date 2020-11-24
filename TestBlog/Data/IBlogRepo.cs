using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestBlog.Models;

namespace TestBlog.Data
{
   public interface IBlogRepo
    {
        Post savePost(Post postToSave);
       IEnumerable<Post> GetPostByHeadline(string Headline);
        IEnumerable<Post> GetByDiscription(Category discription);
        IEnumerable<Post> GetALLpost();
        Post Deletepost(int postToDelete);
        Post Editpost(Post PostUpdate);
        int getpostcount();
        Post GetPost(int Id);
    }
}
