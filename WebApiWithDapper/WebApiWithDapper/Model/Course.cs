using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiWithDapper.Model
{
    public class Course
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }

        public List<StudentCourse> Student_Courses { get; set; }
    }
}
