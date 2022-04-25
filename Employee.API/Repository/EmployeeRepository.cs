using System.Linq;
using Employee.API.Domain;
using Employee.API.Infrastructure.Constants;
using Employee.API.RepositoryAbstractions;

namespace Employee.API.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public bool AddEmployee(EmployeeDto employee)
        {
            employee.Id = EmployeeConstant.List.LastOrDefault()!.Id + 1;
            EmployeeConstant.List.Add(employee);
            return true;
        }

        public bool ToggleActivity(int employeeId)
        {
            var employee = EmployeeConstant.List.FirstOrDefault(x => x.Id == employeeId);

            if (employee == null)
            {
                return false;
            }

            employee.Activity = !employee.Activity;

            return true;
        }
    }
}