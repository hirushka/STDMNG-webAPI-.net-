using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiWithDapper.Model
{
    public class Department
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; }

        public IEnumerable<Course> Courses { get; set; }
    }
}
