using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestBlog.ViewModels
{
    public class LogInViewModel
    {
        //public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remenber Me")]
        public bool RemenberMe { get; set; }
        [EmailAddress]
        public string Email { get; set; }
    }
}
