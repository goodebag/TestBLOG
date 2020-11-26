namespace TestBlog.Models
{
    public class Like
    {
        public string WhoLiked { get; set; }
        public int LikeId { get; set; }
        public int Likes { get; set; }
        public int Postid { get; set; }
        public Post post { get; set; }
    }
}