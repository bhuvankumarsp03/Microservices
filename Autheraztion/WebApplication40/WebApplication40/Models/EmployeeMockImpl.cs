namespace WebApplication40.Models
{
    public class EmployeeMockImpl : IEmployeeRepository
    {
        private static List<Employee> _employeeList;
        private int count = 3;

        public EmployeeMockImpl()
        {
            _employeeList = new List<Employee>();
            _employeeList.Add(new Employee { Id = 1, Name = "Mark", Email  ="m@gmail.com" });
            _employeeList.Add(new Employee { Id = 2, Name = "Paul", Email = "p@gmail.com" });
            _employeeList.Add(new Employee { Id = 3, Name = "John", Email = "j@gmail.com" });
        }
        public Employee AddEmployee(Employee employee)
        {
            employee.Id = ++count;
            _employeeList.Add(employee);
            return employee;
        }

        public List<Employee> GetAllEmployees()
        {
            return _employeeList;
        }

        public Employee GetEmployeeById(int id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == id);
        }
    }
}
