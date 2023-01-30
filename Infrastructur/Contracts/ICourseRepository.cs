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
        /// <summary>
        /// متد کورس های هر دانشجو
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<List<StudentCoursesDto>> GetStudentsCourse(string id);
        /// <summary>
        /// متد دانشجویان حاضر در هر کورس
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<List<StudentInCourses>> GetCouresParticipant(int id);
        /// <summary>
        /// اضافه کردن دانشجو به کورس
        /// </summary>
        /// <param name="Studentid"></param>
        /// <param name="CourseId"></param>
        /// <returns></returns>
        Task<List<StudentInCourses>> AddStudentToCourse(string Studentid, int CourseId);
        /// <summary>
        /// تمامی کورس ها
        /// </summary>
        /// <returns></returns>
        Task<List<Course>> GetCourses();

        /// <summary>
        /// متد دریافت لیست تمامی دانش آموزان
        /// </summary>
        /// <returns></returns>
        Task<List<User>> GetStudents();

    }
}
