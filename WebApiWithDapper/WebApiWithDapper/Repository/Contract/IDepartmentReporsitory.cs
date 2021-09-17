using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiWithDapper.Model;

namespace WebApiWithDapper.Repository.Contract
{
    public interface IDepartmentReporsitory
    {
        public Task<IEnumerable<Department>> GetAllDeptAsync();
        //public Task<Student> GetDeptByIDAsync(DynamicParameters param);
        public Task<int> CreateDeptAsync(DynamicParameters param);
        public Task<Department> getDeptByName(DynamicParameters param);

    }
}
