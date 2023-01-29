using Core.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructur
{
    public class InstituteDbContext : IdentityDbContext
    {
        public InstituteDbContext(DbContextOptions<InstituteDbContext> options) : base(options) { }

        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<UserCourse> UserCourses { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
        }
    }
}
