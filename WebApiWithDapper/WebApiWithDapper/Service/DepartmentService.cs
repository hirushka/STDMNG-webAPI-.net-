using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiWithDapper.Model;
using WebApiWithDapper.Service.Contract;
using WebApiWithDapper.Repository.Contract;
using WebApiWithDapper.Repository;
using Dapper;

namespace WebApiWithDapper.Service
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentReporsitory _departmentRepository;
        private readonly ICourseService _courseService;

        public DepartmentService(IDepartmentReporsitory departmentRepository, ICourseService courseRepository)
        {
            _departmentRepository = departmentRepository;
            _courseService = courseRepository;
        }
        public async Task<int> CreateDeptAsync(Department dept)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@DepartmentName", dept.DepartmentName);
            return await _departmentRepository.CreateDeptAsync(param);
        }

        public async Task<IEnumerable<Department>> GetAllDeptAsync()
        {
            IEnumerable<Department> departmentList = await _departmentRepository.GetAllDeptAsync();

            for (int i=0; i<departmentList.Count(); i++)
            {
                Department item = departmentList.ElementAt(i);
                int deptId = item.Id;
                IEnumerable<Course> courseList = await _courseService.CourseGetByDepartmentIdAsync(deptId);
                item.Courses = courseList;

            }


            return departmentList;
        }

        public async Task<Department> GetDepartmentByNae(string dname)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@Dname", dname);
            return await _departmentRepository.getDeptByName(param);
        }
    }
}
