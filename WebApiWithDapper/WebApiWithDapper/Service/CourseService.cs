using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiWithDapper.Model;
using WebApiWithDapper.Repository.Contract;
using WebApiWithDapper.Service.Contract;

namespace WebApiWithDapper.Service
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseReorsitory;

        public CourseService(ICourseRepository courseRepository)
        {
            _courseReorsitory = courseRepository;
        }
        public async Task<IEnumerable<Course>> CourseGetByDepartmentIdAsync(int id)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@DepartmentId", id);
            return await _courseReorsitory.CourseGetByDepartmentIdAsync(param);
        }

        public async Task<int> CreateCourseByDepartmentIdAsync(Course crs)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@CourseName", crs.CourseName);
            param.Add("@DepartmentId", crs.DepartmentId);
            return await _courseReorsitory.CreateCourseByDepartmentIdAsync(param);
        }


        public async Task<IEnumerable<Course>> GetAllCourseAsync()
        {
            return await _courseReorsitory.GetAllCourseAsync();
        }
    }
}
