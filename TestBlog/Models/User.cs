using Microsoft.AspNetCore.Identity;

namespace TestBlog.Models
{
    public class User:IdentityUser
    {
        public string photopath { get; set; }
    }
}