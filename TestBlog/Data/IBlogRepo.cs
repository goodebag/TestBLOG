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
        RePost addLike(RePost postToAddLike);
        void Removelike(int postid, string userNAME);
        Like SaveLike(Like likeToLike);
        IEnumerable<RePost> addLikes(IEnumerable<RePost> postToAddLikes);
        Comment SaveComent(Comment comment);
        IEnumerable<RePost> AddComents(IEnumerable<RePost> post);
       RePost AddComent(RePost post);
        bool likedBefore(int postid,string userNAME);
        PostTypeCount TypeCount();
        string AddEmail(EmailNotification Email);
        IEnumerable<EmailNotification> GetEmails();
    }
}
