using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class User:IdentityUser
    {
        public bool IsTeacher{ get; set; }
        public int IsStudent { get; set; }

        public ICollection<UserCourse> MyProperty { get; set; }
    }
}
