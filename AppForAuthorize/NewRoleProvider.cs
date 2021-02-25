using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using AppForAuthorize.Models;

namespace AppForAuthorize
{
    public class NewRoleProvider : RoleProvider
    {
        public override string ApplicationName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override void CreateRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            throw new NotImplementedException();
        }

        public override string[] FindUsersInRole(string roleName, string usernameToMatch)
        {
            throw new NotImplementedException();
        }

        public override string[] GetAllRoles()
        {
            throw new NotImplementedException();
        }

        public override string[] GetRolesForUser(string username)
        {
            using (BaseForAuthorize1MEntities db = new BaseForAuthorize1MEntities())
            {
                var user = db.User.FirstOrDefault(u => u.Login == username);
                if (user == null)
                    return null;
                else
                {
                    string[] roles = new string[1];
                    roles[0] = user.Role.Name.ToString();
                    return roles;
                }
            }
            throw new NotImplementedException();
        }

        public override string[] GetUsersInRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool IsUserInRole(string username, string roleName)
        {
            string roles = GetRolesForUser(username)[0];
            if (roleName.Equals(roles, StringComparison.OrdinalIgnoreCase))
                return true;
            else
                return false;
        }

        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override bool RoleExists(string roleName)
        {
            throw new NotImplementedException();
        }
    }
}