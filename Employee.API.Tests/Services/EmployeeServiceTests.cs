using Employee.API.Contracts;
using Employee.API.Controllers;
using Employee.API.Domain;
using Employee.API.Models;
using Employee.API.RepositoryAbstractions;
using Employee.API.Services;
using Employee.API.Tests.TestData;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using Xunit;

namespace Employee.API.Tests.Services
{
    public class EmployeeServiceTests
    {
        [Fact]
        public void AddEmployee_Should_Return_True_With_ValidEmployeeId()
        {
            var employee = Data.EmployeeData.validEmployee;
            var employeeDto = Data.EmployeeData.validEmployeeDto;
            var mockEmployeeRepository = new Mock<IEmployeeRepository>();

            mockEmployeeRepository.Setup(x => x.AddEmployee(employeeDto))
                .Returns(true);

            var employeeService= new EmployeeService(mockEmployeeRepository.Object);
            var result = employeeService.AddEmployee(employee);

            mockEmployeeRepository.Verify(r => r.AddEmployee(It.IsAny<EmployeeDto>()), Times.Once);

            Assert.IsType<bool>(result);
            Assert.False(result);
        }
        
        
        [Fact]
        public void ToggleActivity_Should_Return_True_With_ValidEmployeeId()
        {
            const int employeeId = 2;
            var mockEmployeeRepository = new Mock<IEmployeeRepository>();
            mockEmployeeRepository.Setup(x => x.ToggleActivity(employeeId))
                .Returns(true);

            var employeeService= new EmployeeService(mockEmployeeRepository.Object);
            var result = employeeService.ToggleActivity(employeeId);

            mockEmployeeRepository.Verify(r => r.ToggleActivity(It.IsAny<int>()), Times.Once);

            Assert.IsType<bool>(result);
            Assert.True(result);
        }
    }
}