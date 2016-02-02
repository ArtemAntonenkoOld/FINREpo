using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISharpConvertor.Identity.Entities
{
    public class TestRole : IdentityRole<int, TestUserRole>
    {
        public TestRole() { }
        public TestRole(string name) { Name = name; }
    }
}
