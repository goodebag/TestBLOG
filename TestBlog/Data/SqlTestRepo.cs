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
            return AllPost.OrderByDescending(e => e.Date);
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

        public Like SaveLike(Like postTolike)
        {
            context.GetLikes.Add(postTolike);
            context.SaveChanges();
      
            return postTolike;
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

                if (context.Comments.Where(e => e.PostId == post.PostId) != null)
                {
                    var comments = context.Comments.Where(e => e.PostId == post.PostId).ToList();
                    post.commentCount = comments.Count;
                    post.comment = new List<Comment>();
                    foreach (var cmmt in comments)
                    {
                        post.comment.Add(cmmt);
                       // post.comment = new Comment[] { cmmt };
                    }
               
                }
            }
            return posts;
            //   var currentComment =comments.GetType().
            // post.commentCount = comments.Count();
        }
            
        

        public RePost AddComent(RePost post)
        {
            if (context.Comments.Where(e => e.PostId == post.PostId) != null)
            {
                var comments = context.Comments.Where(e => e.PostId == post.PostId).ToList();
                post.commentCount = comments.Count;
                post.comment = new List<Comment>();
                foreach (var cmmt in comments)
                {
                    post.comment.Add(cmmt);
                    // post.comment = new Comment[] { cmmt };
                }
                //  IEnumerable<string> arr = new string[] { comments.comments };
                //// post.Comments = arr;
                // post.commentCount = comments.comments.Count();
            }
                return post;
        }

        public IEnumerable<RePost> addLikes(IEnumerable<RePost> postToAddLikes)
        {
            foreach (var post in postToAddLikes)
            {
                if (context.GetLikes.Where(e => e.Postid == post.PostId) != null)
                {
                    var Likes = context.GetLikes.Where(e => e.Postid == post.PostId).ToList();
                    post.LikeCount = Likes.Count;
                    post.likes = new List<Like>();
                    foreach (var lkz in Likes)
                    {
                        post.likes.Add(lkz);
                    }
                }
            }
            return postToAddLikes;
        }

        public RePost addLike(RePost post)
        {
            if (context.GetLikes.Where(e => e.Postid == post.PostId) != null)
            {
                var Likes = context.GetLikes.Where(e => e.Postid == post.PostId).ToList();
                post.LikeCount = Likes.Count;
                post.likes = new List<Like>();
                foreach (var lkz in Likes)
                {
                    post.likes.Add(lkz);
                }
            }
            return post;
        }

        public bool likedBefore(int postid,string userNAME)
        {
            var liked = new bool();
            var use = context.GetLikes.Where(e => e.Postid == postid).ToList();
       
            if (use.Where(e=>e.WhoLiked == userNAME).Equals(null))
            {
                liked = false;
            }
            else
            {
                liked = true;
            }
            return liked;
        }

        public void Removelike(int postid, string userNAME)
        {
            var like = context.GetLikes.Where(e => e.Postid == postid).ToList();
            var likeToRemove = like.FirstOrDefault(e => e.WhoLiked == userNAME);
            context.GetLikes.Remove(likeToRemove);
            context.SaveChanges();
        }

        public PostTypeCount TypeCount()
        {
            PostTypeCount postTypes = new PostTypeCount();
          var Entertaainment =  context.Posts.Where(e => e.Discription == Category.Entertainment).ToList();
            postTypes.EntertainmentCount = Entertaainment.Count;
            var TravelNews = context.Posts.Where(e => e.Discription == Category.TravelNews).ToList();
            postTypes.TravelNewsCount = TravelNews.Count;
            var JobsAlert = context.Posts.Where(e => e.Discription == Category.JobsAlert).ToList();
            postTypes.JobAlertCount = JobsAlert.Count;
            var Lifestyle = context.Posts.Where(e => e.Discription == Category.Lifestyle).ToList();
            postTypes.LifestyleCount = Lifestyle.Count;
            var MoviesNews = context.Posts.Where(e => e.Discription == Category.MoviesNews).ToList();
            postTypes.MoviesNewsCount = MoviesNews.Count;
            var SportsNews = context.Posts.Where(e => e.Discription == Category.SportsNews).ToList();
            postTypes.SportNewsCount = SportsNews.Count;
            var MusicNews = context.Posts.Where(e => e.Discription == Category.MusicNews).ToList();
            postTypes.MusicnewsCount = MusicNews.Count;
            return postTypes;
        }
    }
}
