using System;
using GiftCard_Solution.DataAccessLayer;
using GiftCard_Solution.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GiftCard_Solution.Tests.DataAccessLayer
{
    [TestClass]
    public class DbConnectionTest
    {
        [TestMethod]
        public void TestSaveNewUser()
        {
            DbConnection connection = new DbConnection();
            User user = new User();
            user.User_name = "chandra@1234";
            user.Password = "chandrasen";
            user.ConfirmPassword = "chandrasen";
            user.Email = "chandra@gmail.com";
            user.MobileNumber = "9856746532";
            var result = connection.SaveNewUser(user);
            Assert.IsNotNull(result);
            Assert.AreEqual("User Created Successfully", result, "User name entered already  present , please try any other name");
        }

        [TestMethod]
        public void TestUserExist()
        {
            DbConnection connection = new DbConnection();
            
            var result = connection.UserExist("chandra1");
            Assert.IsNotNull(result);
            Assert.AreEqual("", result, "User already Exist");

        }

        [TestMethod]
        public void TestGetConnection()
        {
            DbConnection connection = new DbConnection();
            var result = connection.GetConnection();
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void TestGetUserList()
        {
            DbConnection connection = new DbConnection();
            var result = connection.GetUserList();
            Assert.IsNotNull(result);
        }
    }
}
