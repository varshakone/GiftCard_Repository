using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GiftCard_Solution;
using GiftCard_Solution.Controllers;
using GiftCard_Solution.Models;

namespace GiftCard_Solution.Tests.Controllers
{
    [TestClass]
    public class UserControllerTest
    {
        [TestMethod]
        public void TestCreatNewUser_Post()
        {
            // Arrange
            UserController controller = new UserController();

            User user = new User();
            user.User_name = "Kumar123";
            user.Password = "chandrasen";
            user.ConfirmPassword = "chandrasen";
            user.Email = "chandra@gmail.com";
            user.MobileNumber = "9856746532";
            // Act
            RedirectToRouteResult result = controller.CreateNewUser(user) as RedirectToRouteResult;
            

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Login", result.RouteValues["action"], "User name entered already  present , please try any other name");
        }

        [TestMethod]
        public void TestCreatNewUser_Get()
        {
            // Arrange
            UserController controller = new UserController();

            // Act
            ViewResult result = controller.CreateNewUser() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
