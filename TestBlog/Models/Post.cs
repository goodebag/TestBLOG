using System;
using System.Collections.Generic;

namespace TestBlog.Models
{
    public class Post
    {
        public int PostId { get; set; }
        public string Photopath { get; set; }
        public string postWriteUp { get; set; }
        public Category Discription { get; set; }
        public DateTime Date { get; set; }
        public string Headline { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Like> likes{ get; set; }
        public string WhoPosted { get; set; }
        public string PosterPhotopath { get; internal set; }
    }
}