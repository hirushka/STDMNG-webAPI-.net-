using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiWithDapper.Model
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public int AcedemicYear { get; set; }
        public DateTime RegisteredDate { get; set; }
        public int DepartmentId { get; set; }
        public string Gender { get; set; }
    }
}
