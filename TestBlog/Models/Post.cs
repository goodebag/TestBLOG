﻿using System;
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
        public int CommentsId { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public int ReationsId { get; set; }
        public ICollection<Reaction> Reactions { get; set; }
    }
}