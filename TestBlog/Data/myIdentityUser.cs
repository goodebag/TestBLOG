using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestBlog.Data
{
    public class myIdentityUser:IdentityUser
    {
        public string PhotoPath { get; set; }
        public string FullNames { get; set; }
    }

}
