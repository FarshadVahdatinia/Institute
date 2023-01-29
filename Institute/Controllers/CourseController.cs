using Infrastructur.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
        public ActionResult Index()
        {
           var result= _courseRepository.GetCourses();
            return View(result);
        }

        // GET: CourseController/Details/5
        [HttpGet("GetCourseParticipant")]
        public ActionResult Details(int id)
        {
            var result = _courseRepository.GetCouresParticipant(id);
            return View(result);
        }

        // GET: CourseController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CourseController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddStudentToCourse(string studentId,int CourseId)
        {
            try
            {
               var result= _courseRepository.AddStudentToCourse(studentId, CourseId);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CourseController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CourseController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CourseController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CourseController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
