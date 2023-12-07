using DepartmentService.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DepartmentService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentRepository _repository;

        public DepartmentController(IDepartmentRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var data = _repository.GetAllDepartments();
            return Ok(data);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var data = _repository.GetDepartmentById(id);
            if(data == null) 
                return NotFound("no record found");
            return Ok(data);
        }

        [HttpPost]
        public IActionResult Post(Department department)
        {
            var data = _repository.AddDepartment(department);
            return Ok(data);
        }
    }
}
