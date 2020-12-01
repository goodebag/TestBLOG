using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestBlog.Models;

namespace TestBlog.Data
{
    public class myIdentityUser: IdentityUser
    {
        public string Photophath { get; set; }
        public string Fullname  { get; set; }
        public string customid { get; set; }
        public UserType GetUserType { get; set; }
    }
}
