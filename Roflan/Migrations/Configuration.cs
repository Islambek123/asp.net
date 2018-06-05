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
            context.User.AddOrUpdate(
                           h => h.Id,   // Use Name (or some other unique field) instead of Id
                           new User()
                           {
                               Id = 1,
                               FirstName = "admin",
                               LastName = "admin",
                               Email = "admin@gmail.com",
                               Password = "admin"
                           });


            context.Role.AddOrUpdate(
                           h => h.Id,   // Use Name (or some other unique field) instead of Id
                           new Role
                           {
                               Id = 1,
                               Name = "Admin"
                           });
            context.UserRoles.AddOrUpdate(
                           h => new { h.UserId, h.RoleId },   // Use Name (or some other unique field) instead of Id
                           new UserRoles
                           {
                               UserId = 1,
                               RoleId = 1
                           });

            context.User.AddOrUpdate(
                           h => h.Id,   // Use Name (or some other unique field) instead of Id
                           new User()
                           {
                               Id = 2,
                               FirstName = "user",
                               LastName = "user",
                               Email = "user@gmail.com",
                               Password = "user"
                           });

            context.Role.AddOrUpdate(
                           h => h.Id,   // Use Name (or some other unique field) instead of Id
                           new Role
                           {
                               Id = 2,
                               Name = "User"
                           });
            context.UserRoles.AddOrUpdate(
                           h => new { h.UserId, h.RoleId },   // Use Name (or some other unique field) instead of Id
                           new UserRoles
                           {
                               UserId = 2,
                               RoleId = 2
                           });

        }
    }
}
