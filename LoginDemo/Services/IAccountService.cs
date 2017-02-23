using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LoginDemo.Models;

namespace LoginDemo.Services
{
    public interface IAccountService
    {
        /// <summary>
        /// 获取所以用户
        /// </summary>
        IList<User> GetAllUser();

        /// <summary>
        /// 获取用户
        /// </summary>
        /// <param name="userId">用户Id</param>
        User GetUser(string userId);

        /// <summary>
        /// 获取用户角色
        /// </summary>
        /// <param name="userId">用户Id</param>
        Role GetUserRole(string userId);

        /// <summary>
        /// 获取用户功能
        /// </summary>
        /// <param name="userId">用户Id</param>
        IList<Resource> getUserResources(string userId);
    }
}