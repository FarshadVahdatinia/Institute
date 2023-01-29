using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string TeacherId { get; set; }
        public int UserCourseId { get; set; }

        [ForeignKey("TeacherId")]
        public virtual User Teacher { get; set; }
        
        [ForeignKey("UserCourseId")]
        public virtual UserCourse UserCourse { get; set; }

    }
}
