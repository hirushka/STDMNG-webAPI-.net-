using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiWithDapper.Model;

namespace WebApiWithDapper.Service.Contract
{
    public interface IStudentService
    {
        public Task<IEnumerable<Student>> GetAllStudentAsync();
        public Task<Student> GetStudentByIDAsync(int id);
        public Task<int> CreateStudentAsync(Student std);
        public Task<int> UpdateStudentAsync(Student std);
        public Task<int> HardDeleteStudentAsync(Student std);
    }
}
