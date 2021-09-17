using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiWithDapper.Model;

namespace WebApiWithDapper.Repository.Contract
{
    public interface IStudentCourseRepositroy
    {

        public Task<int> CreateStudentAsync(DynamicParameters param);
        public Task<int> HardDeleteStudentAsync(DynamicParameters param);
        public Task<StudentCourse> GetStudentCourseById(DynamicParameters param);
        public Task<IEnumerable<StudentCourse>> GetStudentCoursesByStudentId(DynamicParameters param);
        
    }

}
