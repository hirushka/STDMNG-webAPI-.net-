using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiWithDapper.Model;
using WebApiWithDapper.Service.Contract;

namespace WebApiWithDapper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {

        private readonly IDepartmentService _departmentService;

        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }
        [HttpGet]
        public async Task<IEnumerable<Department>> Getdepartments()
        {
            return await _departmentService.GetAllDeptAsync();
        }

        [HttpPost]
        public async Task<ActionResult<int>> CreateDepartmentAsync(Department department)
        {
            return await _departmentService.CreateDeptAsync(department);
        }

        [HttpGet("{dname}")]
        public async Task<Department> GetdepartmentByName(String dname)
        {
            return await _departmentService.GetDepartmentByNae(dname);
        }
    }
}
