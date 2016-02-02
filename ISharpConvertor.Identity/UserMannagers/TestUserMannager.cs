using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISharpConvertor.Identity.Entities;

namespace ISharpConvertor.Identity.UserMannagers
{
    public class TestUserStore : UserStore<TestUser, TestRole, int,
        TestUserLogin, TestUserRole, TestUserClaim>
    {
        public TestUserStore(TestIdentityDbContext context)
            : base(context)
        {
        }
    }
}
