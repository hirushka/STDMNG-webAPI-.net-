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
    public class StudentCourseController : ControllerBase
    {
        private readonly IStudentCourseService _studentCourseService;

        public StudentCourseController(IStudentCourseService studentCourseService)
        {
            _studentCourseService = studentCourseService;
        }

        [HttpPost]
        public async Task<ActionResult<int>> CreateStudentAsync(StudentCourse sc)
        {
            return await _studentCourseService.CreateStudentAsync(sc);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<int>> DeleteStudent(int id)
        {
            var std = await _studentCourseService.GetStudentCourseById(id);
            if (std == null)
            {
                NotFound();
            }

            return await _studentCourseService.HardDeleteStudentAsync(std);
        }

        //Get api/ student/id
        [HttpGet("{id}")]
        public async Task<IEnumerable<StudentCourse>> GetStudentById(int id)
        {
            return await _studentCourseService.GetStudentCoursesByStudentId(id);
            
        }


    }
}
