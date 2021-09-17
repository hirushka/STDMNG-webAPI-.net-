using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiWithDapper.Model;
using WebApiWithDapper.Repository.Contract;

namespace WebApiWithDapper.Repository
{
    public class StudentCourseRepository : IStudentCourseRepositroy
    {
       
        public async Task<int> CreateStudentAsync(DynamicParameters param)
        {
            return await DapperORM.ExecuteWithoutReturnAsync("StudentCourseAdd", param);
        }

        public async Task<StudentCourse> GetStudentCourseById(DynamicParameters param)
        {
            return await DapperORM.ReturnObjectAsync<StudentCourse>("StudentCourseGetById", param);
        }

        public async Task<IEnumerable<StudentCourse>> GetStudentCoursesByStudentId(DynamicParameters param)
        {
            return await DapperORM.ReturnListAsync<StudentCourse>("StudentCourseGetByStudentId", param);
        }

        public async Task<int> HardDeleteStudentAsync(DynamicParameters param)
        {
            return await DapperORM.ExecuteWithoutReturnAsync("StudentCourseDelete", param);
        }
    }
}
