using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class UserCourse
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public string StudentId { get; set; }
        public bool IsConfirmed { get; set; }


        public virtual Course course { get; set; }
        public virtual User Student { get; set; }
    }
}
