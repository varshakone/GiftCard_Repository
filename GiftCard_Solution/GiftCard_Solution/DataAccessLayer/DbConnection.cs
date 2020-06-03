using GiftCard_Solution.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GiftCard_Solution.DataAccessLayer
{
    public class DbConnection
    {
        public String SaveNewUser(User user)
        {
            String returnResult = string.Empty;
            String message = UserExist(user.User_name);
            if(message == "user name exist ")
            {
                returnResult = message;
            }
            else
            {
               
                using (UserContext userContext = GetConnection())
                {
                    var result = userContext.Users.Add(user);

                    if (result != null)
                    {
                        userContext.SaveChanges();
                        returnResult = "User Created Successfully";
                    }
                }
            }
          return returnResult;
        }
        public String UserExist(String username)
        {
            String message = string.Empty;
            using (UserContext userContext =  GetConnection())
            {
                var lstUsers = GetUserList();

                var findUser = lstUsers.SingleOrDefault(usr => usr.User_name == username);
                if(findUser !=null)
                {
                    message = "user name exist ";
                }
            }

            return message;
        }

        public UserContext GetConnection()
        {
            UserContext userContext = new UserContext();
           
            return userContext;
        }

        public List<User> GetUserList()
        {
            UserContext userContext = GetConnection();
            var lstUsers = userContext.Users.ToList();
            return lstUsers;
        }

    }
}