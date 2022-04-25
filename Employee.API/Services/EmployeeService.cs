using Employee.API.Contracts;
using Employee.API.Domain;
using Employee.API.Models;
using Employee.API.RepositoryAbstractions;
using Mapster;

namespace Employee.API.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        
        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        
        public bool AddEmployee(EmployeeRequest employee)
        {
            var employeeDto = employee.Adapt<EmployeeDto>();
            return _employeeRepository.AddEmployee(employeeDto);
        } 
        
        public bool ToggleActivity(int employeeId)
        {
            return _employeeRepository.ToggleActivity(employeeId);
        }
    }
}