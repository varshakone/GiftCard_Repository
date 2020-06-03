using System;
using GiftCard_Solution.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GiftCard_Solution.Tests.Model
{
    [TestClass]
    public class UserManipulationTest
    {
        [TestMethod]
        public void TestAddNewUser()
        {
            UserManipulation userManipulation = new UserManipulation();
            User user = new User();
            user.User_name = "chandrasen patil";
            user.Password = "chandrasen";
            user.ConfirmPassword = "chandrasen";
            user.Email = "chandra@gmail.com";
            user.MobileNumber = "9856746532";
            var result = userManipulation.AddNewUser(user);
            Assert.IsNotNull(result);
            Assert.AreEqual("User Created Successfully", result, "User name entered already  present , please try any other name");
        }
    }
}
