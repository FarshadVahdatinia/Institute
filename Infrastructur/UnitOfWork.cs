using Core.Dtos;
using Core.Models;
using Infrastructur.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructur
{
    public class CourseRepository:ICourseRepository
    {
        private readonly InstituteDbContext _dbcontext;
        public CourseRepository(InstituteDbContext dbContext)
        {
            _dbcontext = dbContext;
        }

        public async Task<List<StudentCoursesDto>> GetStudentsCourse(string id)
        {
            var query = _dbcontext.UserCourses.Include(c => c.Student)
                .Include(c => c.course).ThenInclude(c=>c.Teacher).Where(c => c.StudentId == id).AsNoTracking()
                .Select(c => new StudentCoursesDto
                {
                    Id=c.Id,
                    CourseName = c.course.Name,
                    TeacherName = c.course.Teacher.UserName,
                    IsConfirmed = c.IsConfirmed
                });
            return await query.ToListAsync();

        }

        public async Task<List<StudentCoursesDto>> AddStudentsToCourse(int id)
        {
            var query = _dbcontext.UserCourses.where

        }
    }
}
