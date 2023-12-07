namespace EmployeeService.Models
{
    public class EmployeeSqlImpl : IEmployeeRepository
    {
        private readonly EmployeeDbContext _context;

        public EmployeeSqlImpl(EmployeeDbContext context)
        {
            _context = context;
        }

        public Employee AddEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
            return employee;
        }

        public void DeleteEmployee(int id)
        {
            Employee employee = _context.Employees.FirstOrDefault(x => x.Id == id);
            if (employee != null)
            {
                _context.Employees.Remove(employee);
                _context.SaveChanges();
            }
        }

        public List<Employee> GetAllEmployees()
        {
            return _context.Employees.ToList();
        }

        public Employee GetEmployeeById(int id)
        {
            return _context.Employees.FirstOrDefault(emp => emp.Id == id);
        }

        public Employee UpdateEmployee(int id, Employee employee)
        {
            Employee savedEmployee = _context.Employees.FirstOrDefault(x => x.Id == id);
            if (savedEmployee != null)
            {
                savedEmployee.Name = employee.Name;
                savedEmployee.Email = employee.Email;
                _context.SaveChanges();
                return savedEmployee;
            }
            return null;
        }
    }
}
