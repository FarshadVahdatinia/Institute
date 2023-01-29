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

        /// <summary>
        /// متد کورس های هر دانشجو
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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

        /// <summary>
        /// متد دانشجویان حاضر در هر کورس
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<List<StudentInCourses>> GetCouresParticipant(int id)
        {
            var query = _dbcontext.UserCourses.Include(x => x.Student).Where(x => x.CourseId == id).AsNoTracking()
                .Select(x => new StudentInCourses
                {
                    id = x.StudentId,
                    UserName = x.Student.UserName,
                    IsConfirmed = x.IsConfirmed
                });
            return await query.ToListAsync();
        }

        public async Task<List<StudentInCourses>> AddStudentToCourse(string Studentid, int CourseId)
        {
            var userCourse = new UserCourse()
            {
                CourseId = CourseId,
                StudentId = Studentid
            };
            await _dbcontext.UserCourses.AddAsync(userCourse);

            var query = _dbcontext.UserCourses.Include(x => x.Student).Where(x => x.CourseId == CourseId).AsNoTracking()
                  .Select(x => new StudentInCourses
                  {
                      id = x.StudentId,
                      UserName = x.Student.UserName,
                      IsConfirmed = x.IsConfirmed
                  });
            return await query.ToListAsync();

        }

        public async Task<List<Course>> GetCourses()
        {
            return await _dbcontext.Courses.AsNoTracking().ToListAsync();

        }      
        
        public async Task<List<User>> GetStudents()
        {
          return await  _dbcontext.Users.Where(c => c.IsStudent == true).AsNoTracking().ToListAsync();

        }
    }
}
