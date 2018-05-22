using Roflan.Entities;
using System.Web.Security;
using System.Linq;
using System.Data.Entity;
namespace Roflan.Core.Security
{
    public class CustomRoleProvider : RoleProvider
    {
        private static EFContext eFContext;
        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
        {
            throw new System.NotImplementedException();
        }

        public override string ApplicationName
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
                throw new System.NotImplementedException();
            }
        }

        public override void CreateRole(string roleName)
        {
            throw new System.NotImplementedException();
        }

        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            throw new System.NotImplementedException();
        }

        public override string[] FindUsersInRole(string roleName, string usernameToMatch)
        {
            throw new System.NotImplementedException();
        }

        public override string[] GetAllRoles()
        {
            throw new System.NotImplementedException();
        }

        public override string[] GetRolesForUser(string username)
        {
            string[] roles = new string[0];
            using (eFContext = new EFContext())
            {
                var user = eFContext.User
                    .Include(u => u.UserRoles)
                    .SingleOrDefault(u => u.Email == username);
                if (user != null)
                {
                    roles = user.UserRoles
                        .Select(r => r.Roles.Name).ToArray();
                }
            }
            return roles;
            //switch (username)
            //{
            //    case "Admin":
            //        {
            //            return new[] { "Maneger", "Administrator" };
            //        }
            //    case "Manager":
            //        {
            //            return new[] { "Operator", "Maneger" };
            //        }
            //    case "Georges":
            //        {
            //            return new[] { "Customer" };
            //        }
            //    default:
            //        return new string[] { };
            //}
        }

        public override string[] GetUsersInRole(string roleName)
        {
            throw new System.NotImplementedException();
        }

        public override bool IsUserInRole(string username, string roleName)
        {
            throw new System.NotImplementedException();
        }

        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
        {
            throw new System.NotImplementedException();
        }

        public override bool RoleExists(string roleName)
        {
            throw new System.NotImplementedException();
        }
    }
}