namespace Roflan.Migrations
{
    using Roflan.Entities;
    using Roflan.Entities.CategoryRepistory;
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





            context.Category.AddOrUpdate(
                h => h.Id,
                        new Category
                        {
                            Id = 1,
                            Name = "A"
                        }
                );

            context.Subcategory.AddOrUpdate(
                        h => h.Id,
                        new Subcategory
                        {
                            Id = 1,
                            Name = "A1",
                            CategoryId = 1
                        }
                );

            context.Category.AddOrUpdate(
                h => h.Id,
                        new Category
                        {
                            Id = 2,
                            Name = "B"
                        }
                );
            context.Category.AddOrUpdate(
                h => h.Id,
                        new Category
                        {
                            Id = 3,
                            Name = "BE"
                        }
                );


            context.Subcategory.AddOrUpdate(
                        h => h.Id,
                        new Subcategory
                        {
                            Id = 2,
                            Name = "B1",
                            CategoryId = 2
                        }
                );

            context.Category.AddOrUpdate(
                h => h.Id,
                        new Category
                        {
                            Id = 4,
                            Name = "C"
                        }
                );
            context.Category.AddOrUpdate(
                h => h.Id,
                        new Category
                        {
                            Id = 5,
                            Name = "CE"
                        }
                );
            context.Subcategory.AddOrUpdate(
                        h => h.Id,
                        new Subcategory
                        {
                            Id = 3,
                            Name = "Ñ1",
                            CategoryId = 4
                        }
                );
            //context.Subcategory.AddOrUpdate( <- subcategoryofsubcategory
            //            h => h.Id,
            //            new Subcategory
            //            {
            //                Id = 6,
            //                Name = "Ñ1E",
            //                CategoryId = 3
            //            }
            //    );
            context.Category.AddOrUpdate(
                h => h.Id,
                        new Category
                        {
                            Id = 6,
                            Name = "D"
                        }
                );
            context.Category.AddOrUpdate(
                h => h.Id,
                        new Category
                        {
                            Id = 7,
                            Name = "DE"
                        }
                );
            context.Subcategory.AddOrUpdate(
                        h => h.Id,
                        new Subcategory
                        {
                            Id = 4,
                            Name = "D1",
                            CategoryId = 6
                        }
                );
            context.Category.AddOrUpdate(
                h => h.Id,
                        new Category
                        {
                            Id = 8,
                            Name = "E"
                        }
                );
            context.Subcategory.AddOrUpdate(
                        h => h.Id,
                        new Subcategory
                        {
                            Id = 7,
                            Name = "DE",
                            CategoryId = 4
                        }
                );
            context.Subcategory.AddOrUpdate(
                        h => h.Id,
                        new Subcategory
                        {
                            Id = 8,
                            Name = "D1",
                            CategoryId = 4
                        }
                );
            //context.Subcategory.AddOrUpdate(
            //            h => h.Id,
            //            new Subcategory
            //            {
            //                Id = 9,
            //                Name = "D1E",
            //                CategoryId = 4
            //            }
            //    );
            context.Category.AddOrUpdate(
                h => h.Id,
                        new Category
                        {
                            Id = 9,
                            Name = "M"
                        }
                );
            context.Category.AddOrUpdate(
                h => h.Id,
                        new Category
                        {
                            Id = 10,
                            Name = "Tm"
                        }
                );
            context.Category.AddOrUpdate(
                h => h.Id,
                        new Category
                        {
                            Id = 11,
                            Name = "Tb"
                        }
                );
            //context.Category.AddOrUpdate(
            //            h => new { h.Subcategory.Id },
            //            new Category
            //            {
            //                Id = 2,
            //                Name = "B"
            //            }
            //    );
            //context.Category.AddOrUpdate(
            //            h => new { h.Subcategory.Id },
            //            new Category
            //            {
            //                Id = 3,
            //                Name = "C"
            //            }
            //    );
            //context.Category.AddOrUpdate(
            //            h => new { h.Subcategory.Id },
            //            new Category
            //            {
            //                Id = 4,
            //                Name = "D"
            //            }
            //    );
            //context.Category.AddOrUpdate(
            //            h => new { h.Subcategory.Id },
            //            new Category
            //            {
            //                Id = 5,
            //                Name = "E"
            //            }
            //    );

        }
    }
}
