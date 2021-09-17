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
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpGet]
        public async Task<IEnumerable<Course>> GetCourses()
        {
            return await _courseService.GetAllCourseAsync();
        }

        [HttpPost]
        public async Task<ActionResult<int>> CreateCourseAsync(Course crs)
        {
            return await _courseService.CreateCourseByDepartmentIdAsync(crs);
        }

        //Get api/ student/id
        [HttpGet("{id}")]
        public async Task<IEnumerable<Course>> GetCourseByDeptId(int id)
        {
            return await _courseService.CourseGetByDepartmentIdAsync(id);
            
        }


    }
}
