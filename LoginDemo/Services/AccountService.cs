using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LoginDemo.Models;

namespace LoginDemo.Services
{
    public class AccountService : IAccountService
    {

        public IList<Models.User> GetAllUser()
        {
            var dbContext = new DBContext();
            return dbContext.Users.ToList<User>();
        }

        public Models.User GetUser(string userId)
        {
            var dbContext = new DBContext();
            return (User)dbContext.Users.Where(i => i.UserId == userId);
        }

        public Models.Role GetUserRole(string userId)
        {
            var dbContext = new DBContext();
            return dbContext.Users.FirstOrDefault(i => i.UserId == userId).Role;
        }

        public IList<Resource> getRoleResources(string roleId)
        {
            var dbContext = new DBContext();
            return null;
        }

        public IList<Models.Resource> getUserResources(string userId)
        {
            return null;
        }
    }
}