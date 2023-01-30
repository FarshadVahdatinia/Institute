using Infrastructur.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Institute.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourseRepository _courseRepository;
        public CourseController(ICourseRepository repository)
        {
            _courseRepository = repository;
        }
        [HttpGet("GetCourses")]
        public ActionResult GetCourses()
        {
           var result= _courseRepository.GetCourses();
            return View(result);
        }

        // GET: CourseController/Details/5
        [HttpGet("GetCourseParticipant")]
        public ActionResult GetCourseParticipant(int id)
        {
            var result = _courseRepository.GetCouresParticipant(id);
            return View(result);
        }


        // POST: CourseController/Create
        [HttpPost("AddStudentToCourse")]
        public ActionResult AddStudentToCourse(string studentId,int CourseId)
        {
            try
            {
               var result= _courseRepository.AddStudentToCourse(studentId, CourseId);
                return View(result);
            }
            catch(Exception ex)
            {
                return View(ex);
            }
        }
    }
}
