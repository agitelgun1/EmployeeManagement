using Employee.API.Repository;
using Employee.API.Tests.TestData;
using Xunit;

namespace Employee.API.Tests.Repository
{
    public class EmployeeRepositoryTests
    {
        [Fact]
        public void AddEmployee_Should_Return_True_With_NewEmployee()
        {
            var employee = Data.EmployeeData.validEmployeeDto;
            
            var employeeRepository = new EmployeeRepository();

            var result = employeeRepository.AddEmployee(employee);

            var response = Assert.IsType<bool>(result);
            var model = Assert.IsAssignableFrom<bool>(response);

            Assert.IsType<bool>(result);
            Assert.True(model);
        }
        
        [Fact]
        public void ToggleActivity_Should_Return_True_With_ExistEmployeeId()
        {
            var employeeId = 2;
            
            var employeeRepository = new EmployeeRepository();

            var result = employeeRepository.ToggleActivity(employeeId);

            var response = Assert.IsType<bool>(result);
            var model = Assert.IsAssignableFrom<bool>(response);

            Assert.IsType<bool>(result);
            Assert.True(model);
        }
        
        [Fact]
        public void ToggleActivity_Should_Return_True_With_InvalidEmployeeId()
        {
            var employeeId = 5;
            
            var employeeRepository = new EmployeeRepository();

            var result = employeeRepository.ToggleActivity(employeeId);

            var response = Assert.IsType<bool>(result);
            var model = Assert.IsAssignableFrom<bool>(response);
          
            Assert.IsType<bool>(result);
            Assert.False(model);
        }
    }
}