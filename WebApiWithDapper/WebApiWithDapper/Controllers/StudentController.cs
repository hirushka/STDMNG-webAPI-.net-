using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiWithDapper.Model;
using WebApiWithDapper.Repository.Contract;
using WebApiWithDapper.Service.Contract;

namespace WebApiWithDapper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public async Task<IEnumerable<Student>> GetStudents()
        {
            return  await _studentService.GetAllStudentAsync();
        }

        [HttpPost]
        public async Task<ActionResult<int>> CreateStudentAsync(Student std)
        {
            return await _studentService.CreateStudentAsync(std);
        }

        //Get api/ student/id
        [HttpGet("{id}")]
        public async Task<ActionResult<Student>> GetStudentById(int id)
        {
            var std = await _studentService.GetStudentByIDAsync(id);
            if (std == null)
            {
                return NotFound();
            }

            return std;
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<int>> PutStudent(int id, Student std)
        {
            if (id != std.Id)
            {
                return BadRequest();
            }

            return await _studentService.UpdateStudentAsync(std);


        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<int>> DeleteStudent(int id)
        {
            var std = await _studentService.GetStudentByIDAsync(id);
            if (std == null)
            {
                NotFound();
            }

            return await _studentService.HardDeleteStudentAsync(std);
        }

    }
}
