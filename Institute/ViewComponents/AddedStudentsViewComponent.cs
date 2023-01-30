using Infrastructur.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Institute.ViewComponents
{
    public class AddedStudentsViewComponent:ViewComponent
    {
        private readonly ICourseRepository _repository;
        public AddedStudentsViewComponent(ICourseRepository repository)
        {
            _repository = repository;
        }
        public async Task<IViewComponentResult> InvokeAsync(int CourseId)
        {
            var students = _repository.GetCouresParticipant(CourseId);

            return await Task.FromResult((IViewComponentResult)View("AddedStudents", students));
        }
    }
}
