using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using GiftCard_Solution.Models;

namespace GiftCard_Solution.DataAccessLayer
{
    public class UserContext : DbContext
    {
        public UserContext():base("GC_DB")
        {

        }

        public DbSet<User> Users { get; set; }
    }
}