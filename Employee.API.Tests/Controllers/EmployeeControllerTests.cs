using Employee.API.Contracts;
using Employee.API.Controllers;
using Employee.API.Enums;
using Employee.API.Models;
using Employee.API.Tests.TestData;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using Xunit;

namespace Employee.API.Tests.Controllers
{
    public class EmployeeControllerTests
    {
        [Fact]
        public void AddEmployee_Should_Return_As_Expected()
        {
            var employee = Data.EmployeeData.validEmployee;
            var mockLogger = new Mock<ILogger<EmployeeController>>();
            var mockEmployeeService = new Mock<IEmployeeService>();

            mockEmployeeService.Setup(x => x.AddEmployee(employee))
                .Returns(true);

            var employeeController = new EmployeeController(mockLogger.Object, mockEmployeeService.Object);
            var result = employeeController.Create(employee);

            mockEmployeeService.Verify(r => r.AddEmployee(It.IsAny<EmployeeRequest>()), Times.Once);

            Assert.IsType<OkResult>(result);
        }
        
        [Fact]
        public void AddEmployee_Should_Return_As_UnExpected()
        {
            var employee = Data.EmployeeData.validEmployee;
            var mockLogger = new Mock<ILogger<EmployeeController>>();
            var mockEmployeeService = new Mock<IEmployeeService>();

            mockEmployeeService.Setup(x => x.AddEmployee(employee))
                .Returns(false);

            var employeeController = new EmployeeController(mockLogger.Object, mockEmployeeService.Object);
            var result = employeeController.Create(employee);

            mockEmployeeService.Verify(r => r.AddEmployee(It.IsAny<EmployeeRequest>()), Times.Once);

            Assert.IsType<ConflictResult>(result);
        }
        
        [Fact]
        public void ToggleActivity_Should_Return_As_Expected()
        {
            const int employeeId = 1;
            
            var mockLogger = new Mock<ILogger<EmployeeController>>();
            var mockEmployeeService = new Mock<IEmployeeService>();

            mockEmployeeService.Setup(x => x.ToggleActivity(employeeId))
                .Returns(true);

            var employeeController = new EmployeeController(mockLogger.Object, mockEmployeeService.Object);
            var result = employeeController.ToggleActivity(employeeId);

            mockEmployeeService.Verify(r => r.ToggleActivity(It.IsAny<int>()), Times.Once);

            Assert.IsType<OkResult>(result);
        }
        
        [Fact]
        public void ToggleActivity_Should_Return_As_UnExpected()
        {
            const int employeeId = 5;
            
            var mockLogger = new Mock<ILogger<EmployeeController>>();
            var mockEmployeeService = new Mock<IEmployeeService>();

            mockEmployeeService.Setup(x => x.ToggleActivity(employeeId))
                .Returns(false);

            var employeeController = new EmployeeController(mockLogger.Object, mockEmployeeService.Object);
            var result = employeeController.ToggleActivity(employeeId);

            mockEmployeeService.Verify(r => r.ToggleActivity(It.IsAny<int>()), Times.Once);

            Assert.IsType<NotFoundResult>(result);
        }
    }
}