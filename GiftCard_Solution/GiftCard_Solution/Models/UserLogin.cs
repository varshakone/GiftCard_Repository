using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace GiftCard_Solution.Models
{
    public class UserLogin
    {
        [Display(Name ="UserName")]
        public String UserName { get; set; }

        [Display(Name = "Password")]
        public String Password { get; set; }
    }
}