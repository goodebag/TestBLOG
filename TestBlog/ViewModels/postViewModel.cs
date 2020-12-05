using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TestBlog.Models;

namespace TestBlog.ViewModels
{
    public class postViewModel
    {
        [Required]
        public string postWriteUp { get; set; }
        [Required]
        public Category Description { get; set; }
        public DateTime Date { get; set; }
        [Required]
        public string Headline { get; set; }
        [Required]
        public IFormFile Photo { get; set; }
        public string Photopath { get; set; }
        public string whoIsPosting { get; set; }
    }
}
