using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiWithDapper.Model;

namespace WebApiWithDapper.Repository.Contract
{
    public interface IStudentRepository
    {
        public  Task<IEnumerable<Student>> GetAllStudentAsync();
        public Task<Student> GetStudentByIDAsync(DynamicParameters param);
        public Task<int> CreateStudentAsync(DynamicParameters param);
        public Task<int> UpdateStudentAsync(DynamicParameters param);
        public Task<int> HardDeleteStudentAsync(DynamicParameters param);
    }
}
