using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiWithDapper.Model;

namespace WebApiWithDapper.Service.Contract
{
    public interface IStudentCourseService
    {
        public Task<int> CreateStudentAsync(StudentCourse sc);
        public Task<int> HardDeleteStudentAsync(StudentCourse sc);
        public Task<IEnumerable<StudentCourse>> GetStudentCoursesByStudentId(int id);
        public  Task<StudentCourse> GetStudentCourseById(int id);
    }
}
