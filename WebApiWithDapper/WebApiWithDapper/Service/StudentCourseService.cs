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
    public class StudentCourseService : IStudentCourseService
    {
        private readonly IStudentCourseRepositroy _studentCourseRepository;

        public StudentCourseService(IStudentCourseRepositroy studentCourseRepositroy)
        {
            _studentCourseRepository = studentCourseRepositroy;
        }

        public async Task<int> CreateStudentAsync(StudentCourse sc)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@StudentId", sc.StudentId);
            param.Add("@CourseId", sc.CourseId);
            return await _studentCourseRepository.CreateStudentAsync(param);
        }

        public async Task<StudentCourse> GetStudentCourseById(int id)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@Id", id);
            return await _studentCourseRepository.GetStudentCourseById(param);
        }

        public async Task<IEnumerable<StudentCourse>> GetStudentCoursesByStudentId(int id)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@StudentId", id);
            return await _studentCourseRepository.GetStudentCoursesByStudentId(param);
        }

        public async Task<int> HardDeleteStudentAsync(StudentCourse sc)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@Id", sc.Id);
            return await _studentCourseRepository.HardDeleteStudentAsync(param);
        }

    }
}
