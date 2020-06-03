using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace GiftCard_Solution.Models
{
    public class User
    {
        public User()
        {
            User_Id = Guid.NewGuid();
        }
        [Key]
        public Guid User_Id { get; set; }

        [Display(Name ="User Name")]
        [Required(ErrorMessage ="Please provide user name")]
        
        public String  User_name { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Please provide password")]
        public String Password { get; set; }

        [Display(Name = "Confirm Password")]
        [Required(ErrorMessage = "Please provide confirm password")]
        [Compare("Password",ErrorMessage ="password and confirm password fields do not match")]
        public String ConfirmPassword { get; set; }


        [Display(Name = "Email")]
        [Required(ErrorMessage = "Please provide Email")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Please enter correct email")]
        public String Email { get; set; }

        [Display(Name = "Mobile Number")]
        [Required(ErrorMessage = "Please provide mobile number")]
        
         [Phone(ErrorMessage ="mobile")]
        public String MobileNumber{ get; set; }

        [Display(Name = "User Type")]
        [Required(ErrorMessage = "Please provide user type")]
        public UserType Usertype { get; set; }

    }
}