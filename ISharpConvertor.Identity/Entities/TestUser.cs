using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Security.Claims;

namespace ISharpConvertor.Identity.Entities
{
    public class TestUser :
        IdentityUser<int, TestUserLogin, TestUserRole, TestUserClaim>
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(
          UserManager<TestUser, int> manager,
          string authenticationType)
        {
            var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);
            return userIdentity;
        }
        public ClaimsIdentity GenerateUserIdentity(
            UserManager<TestUser, int> manager,
            string authenticationType)
        {
            var userIdentity = manager.CreateIdentity(this, authenticationType);

            return userIdentity;
        }
    }
}
