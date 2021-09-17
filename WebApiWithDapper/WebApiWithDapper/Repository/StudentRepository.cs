using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiWithDapper.Model;
using WebApiWithDapper.Repository.Contract;

namespace WebApiWithDapper.Repository
{
    public class StudentRepository:IStudentRepository
    {
        public async Task<int> CreateStudentAsync(DynamicParameters param)
        {
            return await DapperORM.ExecuteWithoutReturnAsync("StudentAddOrEdit", param);
        }

        public async Task<IEnumerable<Student>> GetAllStudentAsync()
        {
            return await DapperORM.ReturnListAsync<Student>("StudentGetAll", null);
        }

        public async Task<Student> GetStudentByIDAsync(DynamicParameters param)
        {
            return await DapperORM.ReturnObjectAsync<Student>("StudentGetById", param);
        }

        public async Task<int> HardDeleteStudentAsync(DynamicParameters param)
        {
            return await DapperORM.ExecuteWithoutReturnAsync("StudentDeleteById", param);
        }

        public async Task<int> UpdateStudentAsync(DynamicParameters param)
        {
            return await DapperORM.ExecuteWithoutReturnAsync("StudentAddOrEdit", param);
        }
    }
}
