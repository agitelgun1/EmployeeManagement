using Employee.API.Models;

namespace Employee.API.Contracts
{
    public interface IEmployeeService
    {
        bool AddEmployee(EmployeeRequest employee);
        bool ToggleActivity(int employeeId);
    }
}