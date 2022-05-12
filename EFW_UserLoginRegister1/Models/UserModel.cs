using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EFW_UserLoginRegister1.Models
{
    public class UserModel
    {
        public int UserId { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = " First is Required")]
        [Display(Name ="First Name: ")]
        public string FirstName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Last Name is Required")]
        [Display(Name = "Last Name: ")]
        public string LastName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Email is Required")]
        [Display(Name = "Email: ")]
        public string Email { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Password is Required")]
        [Display(Name = "Password: ")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Confirm-Password is Required")]
        [Display(Name = "Confirm Password: ")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password and Confirm-Password must be same")]
        public string ConfirmPassword { get; set; }
        public DateTime Created_On { get; set; }
    }
}