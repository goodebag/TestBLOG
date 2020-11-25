using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestBlog.Models;
using TestBlog.ViewModels;

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
        int SaveLike(int postToLike);
        Comment SaveComent(Comment comment);
        IEnumerable<RePost> AddComents(IEnumerable<RePost> post);
       RePost AddComent(RePost post);
    }
}
