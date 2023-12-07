using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication40.Models;

namespace WebApplication40.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult Get()
        {
            var data = _employeeRepository.GetAllEmployees();
            return Ok(data);
        }

       
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var data = _employeeRepository.GetEmployeeById(id);
            if (data == null)
                return NotFound("no record found");
            return Ok(data);
        }

        [HttpPost]
        public IActionResult Post(Employee employee)
        {
            var data = _employeeRepository.AddEmployee(employee);
            return Ok(data);
        }
    }
}
