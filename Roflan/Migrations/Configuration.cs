namespace Roflan.Migrations
{
    using Roflan.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Roflan.Entities.EFContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Roflan.Entities.EFContext context)
        {
            using (context = new Entities.EFContext())
            {
                if (!context.Role.Any(r=>r.Name == "Admin") && !context.UserRoles.Any(r=> r.Roles.Name == "Admin"))
                {
                    var user = new User()
                    {
                        FirstName = "admin",
                        LastName = "admin",
                        Email = "admin@gmail.com",
                        Password = "admin"
                    };
                    var admin = new Role()
                    {
                        Name = "Admin"
                    };
                    var userRole = new UserRoles
                    {
                        Users = user,
                        Roles = admin
                    };

                    context.UserRoles.Add(userRole); 
                    context.SaveChanges();
                }
                if (!context.Role.Any(r => r.Name == "User") && !context.UserRoles.Any(r => r.Roles.Name == "User"))
                {
                    var user = new User()
                    {
                        FirstName = "user",
                        LastName = "user",
                        Email = "user@gmail.com",
                        Password = "user"
                    };
                    var customUser = new Role()
                    {
                        Name = "User"
                    };
                    var userRole = new UserRoles
                    {
                        Users = user,
                        Roles = customUser
                    };

                    context.UserRoles.Add(userRole); // will also add comment3
                    context.SaveChanges();
                }
            }
        }
    }
}
