namespace DepartmentService.Models
{
    public class DepartmentMockImpl : IDepartmentRepository
    {
        private static List<Department> _departments;
        private int count = 3;

        public DepartmentMockImpl()
        {
            _departments = new List<Department>();
            _departments.Add(new Department { Id = 1, Name = "Admin", Address = "India" });
            _departments.Add(new Department { Id = 2, Name = "Sales", Address = "India" });
            _departments.Add(new Department { Id = 3, Name = "HR", Address = "India" });
        }

        public Department AddDepartment(Department department)
        {
            department.Id = ++count;
            _departments.Add(department);
            return department;
        }

        public List<Department> GetAllDepartments()
        {
            return _departments;
        }

        public Department GetDepartmentById(int id)
        {
            return _departments.FirstOrDefault(dep => dep.Id == id);
        }
    }
}
