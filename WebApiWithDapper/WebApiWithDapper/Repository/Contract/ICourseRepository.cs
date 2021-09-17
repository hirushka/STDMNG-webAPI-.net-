using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiWithDapper.Model;

namespace WebApiWithDapper.Repository.Contract
{
    public interface ICourseRepository
    {
        public Task<int> CreateCourseByDepartmentIdAsync(DynamicParameters param);
        public Task<IEnumerable<Course>> GetAllCourseAsync();

        public  Task<IEnumerable<Course>> CourseGetByDepartmentIdAsync(DynamicParameters param);
            
    }
}
