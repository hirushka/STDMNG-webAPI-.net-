using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiWithDapper.Model;
using WebApiWithDapper.Repository.Contract;

namespace WebApiWithDapper.Repository
{
    public class DepartmentRepository : IDepartmentReporsitory
    {
        public async Task<int> CreateDeptAsync(DynamicParameters param)
        {
            return await DapperORM.ExecuteWithoutReturnAsync("DepartmentAdd", param);
        }

        public async Task<IEnumerable<Department>> GetAllDeptAsync()
        {
            return await DapperORM.ReturnListAsync<Department>("DepartmentGetAll", null);
        }

        public async Task<Department> getDeptByName(DynamicParameters param)
        {
            return await DapperORM.ReturnObjectAsync<Department>("DepartmentGetByName", param);
        }

        /*public async Task<Department> GetDeptByIDAsync(DynamicParameters param)
        {
            return await DapperORM.ReturnObjectAsync<Department>("DeprtmentGetById", param);
        }*/
    }
}
