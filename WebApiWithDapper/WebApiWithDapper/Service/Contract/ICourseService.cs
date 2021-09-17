using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiWithDapper.Model;

namespace WebApiWithDapper.Service.Contract
{
    public interface ICourseService
    {
        public Task<IEnumerable<Course>> CourseGetByDepartmentIdAsync(int id);
        public Task<int> CreateCourseByDepartmentIdAsync(Course crs);
        public Task<IEnumerable<Course>> GetAllCourseAsync();
    }
}
