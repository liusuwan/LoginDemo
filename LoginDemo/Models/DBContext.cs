using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace LoginDemo.Models
{
    public class DBContext : DbContext
    {
        public DBContext()
            : base("LoginDB")
        {
            Database.SetInitializer<DBContext>(new DropCreateDatabaseIfModelChanges<DBContext>());
            if (this.Roles.ToList().Count <= 0)
            {
                InitData();
            }
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Resource> Resources { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        //填充数据
        public void InitData()
        {
            Resource resource1 = new Resource() { Name = "功能1", ResourceId = "Res1" };
            Resource resource2 = new Resource() { Name = "功能2", ResourceId = "Res2" };
            Resource resource3 = new Resource() { Name = "功能3", ResourceId = "Res3" };
            Resource resource4 = new Resource() { Name = "功能4", ResourceId = "Res4" };
            Resource resource5 = new Resource() { Name = "功能5", ResourceId = "Res5" };

            this.Resources.Add(resource1);
            this.Resources.Add(resource2);
            this.Resources.Add(resource3);
            this.Resources.Add(resource4);
            this.Resources.Add(resource5);

            Role role1 = new Role() { Name = "角色1", RoleId = "Role1", Resources = new List<Resource>() { resource1, resource2, resource3 } };
            Role role2 = new Role() { Name = "角色2", RoleId = "Role2", Resources = new List<Resource>() { resource3, resource4, resource5 } };

            this.Roles.Add(role1);
            this.Roles.Add(role2);

            User user1 = new User() { Name = "Tina", UserId = "Tina", Role = role1 };
            User user2 = new User() { Name = "May", UserId = "May", Role = role2 };

            this.Users.Add(user1);
            this.Users.Add(user2);
            this.SaveChanges();
        }
    }

}