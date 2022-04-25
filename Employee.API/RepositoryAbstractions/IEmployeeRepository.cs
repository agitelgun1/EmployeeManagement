using Employee.API.Domain;

namespace Employee.API.RepositoryAbstractions
{
    public interface IEmployeeRepository
    {
        bool AddEmployee(EmployeeDto employee);
        bool ToggleActivity(int employeeId);
    }
}