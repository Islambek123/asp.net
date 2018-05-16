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
        //public DbSet<UserRole> UserRole { get; set; }
    }
}