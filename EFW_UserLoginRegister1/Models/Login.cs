using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EFW_UserLoginRegister1.Models
{
    public class Login
    {
        [Required(ErrorMessage ="Email is Required")]
        [Display(Name ="Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is Required")]
        public string Password { get; set; }
    }
}