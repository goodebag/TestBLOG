using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestBlog.Models;

namespace TestBlog.ViewModels
{
    public class RePost
    {

        public int PostId { get; set; }
        public string Photopath { get; set; }
        public string postWriteUp { get; set; }
        public Category Discription { get; set; }
        public DateTime Date { get; set; }
        public string Headline { get; set; }
        public IEnumerable<string> Comments { get; set; }
        public int likes { get; set; }
        public int commentCount { get; set; }
    }
}
