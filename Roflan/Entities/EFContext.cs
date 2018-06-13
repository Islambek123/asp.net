using Roflan.Entities.CategoryRepistory;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Roflan.Entities
{
    public class EFContext : DbContext
    {
        public EFContext() : base("DefaultConnection")
        {

        }
        public DbSet<User> User { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<UserRoles> UserRoles { get; set; }
        //public DbSet<UserRole> UserRole { get; set; }
        public DbSet<Category> Category { get; set; }

        public DbSet<Subcategory> Subcategory { get; set; }
    }
}