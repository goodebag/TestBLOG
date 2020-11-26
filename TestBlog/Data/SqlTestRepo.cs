using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestBlog.Models;
using TestBlog.ViewModels;

namespace TestBlog.Data
{
    public class SqlTestRepo : IBlogRepo
    {
        private readonly AppDbContext context;

        public SqlTestRepo(AppDbContext context)
        {
            this.context = context;
        }

        public Comment SaveComent(Comment comment)
        {
            context.Comments.Add(comment);
            context.SaveChanges();
            return comment;
        }

        public Post Deletepost(int postToDelete)
        {
          Post post =  context.Posts.Find(postToDelete);
            context.Remove(post);
            context.SaveChanges();
            return post;
        }

        public Post Editpost(Post PostUpdate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Post> GetALLpost()
        {
          var AllPost=  context.Posts;
            return AllPost;
        }

        public IEnumerable<Post> GetByDiscription(Category discription)
        {
            IEnumerable<Post> query = context.Posts.Where(POST => POST.Discription == discription);

            return query;
        }

        public Post GetPost(int Id)
        {
            var post = context.Posts.Find(Id);
            return post;
        }

        public IEnumerable<Post> GetPostByHeadline(string Headline)
        {
            IEnumerable<Post> query = context.Posts;
           var MATCHES = query.Where(post => post.Headline.Contains(Headline));
            return MATCHES.OrderByDescending(e =>e.Date);
        }

        public int getpostcount()
        {
            return context.Posts.Count();
        }

        public int SaveLike(int postToLikePostId)
        {
          //var liked =   context.Posts.Find(postToLikePostId).LIKE +=1;
            context.SaveChanges();
            // return liked;
            return 1;
        }


        public Post savePost(Post postToSave)
        {
            context.Posts.Add(postToSave);
            context.SaveChanges();
            return postToSave;
        }

        public IEnumerable<RePost> AddComents(IEnumerable<RePost> posts)
        {
            foreach (var post in posts)
            {
                IEnumerable<Comment> comments = context.Comments.Where(e => e.PostId == post.PostId).ToList();
                post.Comments = comments.Select(e => e.comments).ToList();
                post.commentCount = comments.Count();
            }
            return posts;
        }

        public RePost AddComent(RePost post)
        {
            Comment comments = context.Comments.FirstOrDefault(e => e.PostId == post.PostId);
             IEnumerable<string> arr = new string[] { comments.comments };
            post.Comments = arr;
            post.commentCount = comments.comments.Count();
            return post;
        }
    }
}
