using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiWithDapper.Model;

namespace WebApiWithDapper.Service.Contract
{
    public interface IDepartmentService
    {
        public Task<IEnumerable<Department>> GetAllDeptAsync();
        //public Task<Student> GetDeptByIDAsync(DynamicParameters param);
        public Task<int> CreateDeptAsync(Department dept);
        public Task<Department> GetDepartmentByNae(String dname);

    }
}
