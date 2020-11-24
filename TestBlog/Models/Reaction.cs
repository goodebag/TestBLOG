namespace TestBlog.Models
{
    public class Reaction
    {
        public int LIke { get; set; }
        public int Love { get; set; }
        public int Sad { get; set; }
        public int Angry { get; set; }
        public int Wow { get; set; }
        public int Care { get; set; }
        public int Hate { get; set; }
        public int ReactionId { get; set; }
        public int PostId { get; set; }
        public Post Post { get; set; }

    }
}