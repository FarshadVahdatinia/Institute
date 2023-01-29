using Core.Dtos;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructur.Contracts
{
    public interface ICourseRepository
    {
        Task<List<StudentCoursesDto>> GetStudentsCourse(string id);
        Task<List<StudentInCourses>> GetCouresParticipant(int id);
        Task<List<StudentInCourses>> AddStudentToCourse(string Studentid, int CourseId);
        Task<List<Course>> GetCourses();

    }
}
