using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestBlog.Models
{
    public class EmailNotification
    {
        [Key]
        public string EmailAddress { get; set; }
    }
}
