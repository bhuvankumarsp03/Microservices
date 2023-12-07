namespace DepartmentService.Models
{
    public interface IDepartmentRepository
    {
        List<Department> GetAllDepartments();
        Department GetDepartmentById(int id);
        Department AddDepartment(Department department);
    }
}
