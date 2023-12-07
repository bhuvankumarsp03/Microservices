using EmployeeService.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

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
                return NotFound("no record found with id: " + id);
            return Ok(data);
        }

        [HttpPost]
        public IActionResult Post(Employee employee)
        {
            var data = _employeeRepository.AddEmployee(employee);
            return Ok(data);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Employee employee)
        {
            var data = _employeeRepository.UpdateEmployee(id, employee);
            return Ok(data);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id) 
        { 
            _employeeRepository.DeleteEmployee(id); 
            return NoContent();
        }
    }
}
