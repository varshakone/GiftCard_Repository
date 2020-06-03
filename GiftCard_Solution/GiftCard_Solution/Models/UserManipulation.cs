using GiftCard_Solution.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GiftCard_Solution.Models
{
    public class UserManipulation
    {
        public String AddNewUser(User user)
        {
            DbConnection dbConnection = new DbConnection();

            String message = dbConnection.SaveNewUser(user);
            return message;
        }
    }
}