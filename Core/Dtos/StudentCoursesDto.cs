using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos
{
    public class StudentCoursesDto
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public string TeacherName { get; set; }
        public bool  IsConfirmed { get; set; }
    }
}
