namespace TestBlog.Models
{
    public class Like
    {
        public int UserId { get; set; }
        public User GetUser { get; set; }
        public int LikeId { get; set; }
        public int Likes { get; set; }
        public int Postid { get; set; }
        public Post post { get; set; }
    }
}