using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestBlog.Models;

namespace TestBlog.Data
{
    public class SqlTestRepo : IBlogRepo
    {
        private readonly AppDbContext context;

        public SqlTestRepo(AppDbContext context)
        {
            this.context = context;
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
            var AllPost = context.Posts;
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

        public Post savePost(Post postToSave)
        {
            context.Posts.Add(postToSave);
            context.SaveChanges();
            return postToSave;
        }
    }
}
