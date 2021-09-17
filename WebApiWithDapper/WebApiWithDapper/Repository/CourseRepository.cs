using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiWithDapper.Model;
using WebApiWithDapper.Repository.Contract;

namespace WebApiWithDapper.Service
{
    public class CourseRepository : ICourseRepository
    {
        public async Task<int> CreateCourseByDepartmentIdAsync(DynamicParameters param)
        {
            return await DapperORM.ExecuteWithoutReturnAsync("CourseAddByDepartmentId", param);
        }

        public async Task<IEnumerable<Course>> GetAllCourseAsync()
        {
            return await DapperORM.ReturnListAsync<Course>("CourseGetAll", null);
        }

        public async Task<IEnumerable<Course>> CourseGetByDepartmentIdAsync(DynamicParameters param)
        {
            return await DapperORM.ReturnListAsync<Course>("CourseGetByDepartmentId", param);
        }

    }
}
