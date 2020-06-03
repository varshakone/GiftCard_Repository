using GiftCard_Solution.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GiftCard_Solution.Controllers
{
   
    public class UserController : Controller
    {
     
        public ActionResult CreateNewUser()
        {
            try
            {
               return View();
            }
            catch (Exception exception)
            {
                //return View("Error");
                return RedirectToAction("Error", new { @exception = exception.Message });
            }
        }

        [HttpPost]
        public ActionResult CreateNewUser(User user)
        {
            try
            {
                UserManipulation manipulation = new UserManipulation();

                var message = manipulation.AddNewUser(user);
                if (message == "user name exist ")
                {
                    ViewBag.message = "This user name is already exist, please try any other user name";
                }
                else
                {
                    return RedirectToAction("Login");//here actually redirect to Login page
                }
                return View();
            }
            catch(Exception exception)
            {
                return RedirectToAction("Error",new { @exception = exception.Message });
            }
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Error(String exception)
        {
            ViewBag.message = exception;
            return View();
        }

    }
}