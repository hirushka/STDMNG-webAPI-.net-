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
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public async Task<IEnumerable<Student>> GetAllStudentAsync()
        {
            return await _studentRepository.GetAllStudentAsync();
        }

        public async Task<int> CreateStudentAsync(Student std)
        {
            DateTime now = DateTime.Now;
            std.RegisteredDate = now;

            DynamicParameters param = new DynamicParameters();
            param.Add("@Id", std.Id);
            param.Add("@Name", std.Name );
            param.Add("@Email", std.Email);
            param.Add("@Age", std.Age);  
            param.Add("@AcedemicYear", std.AcedemicYear);
            param.Add("@RegisterDate", now);
            param.Add("@DepartmentId", std.DepartmentId);
            param.Add("@Gender", std.Gender);

            return await _studentRepository.CreateStudentAsync(param);
        }

        public async Task<Student> GetStudentByIDAsync(int id)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@Id", id);
            return await _studentRepository.GetStudentByIDAsync(param);
        }

        public async Task<int> HardDeleteStudentAsync(Student std)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@Id", std.Id);
            return await _studentRepository.HardDeleteStudentAsync(param);
        }

        public async Task<int> UpdateStudentAsync(Student std)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@Id", std.Id);
            param.Add("@Name", std.Name);
            param.Add("@Email", std.Email);
            param.Add("@Age", std.Age);
            param.Add("@AcedemicYear", std.AcedemicYear);
            param.Add("@RegisterDate", std.RegisteredDate);
            param.Add("@DepartmentId", std.DepartmentId);
            param.Add("@Gender", std.Gender);
            return await _studentRepository.UpdateStudentAsync(param);
        }
    }
}
