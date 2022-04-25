using Employee.API.Domain;
using Employee.API.Enums;
using Employee.API.Models;

namespace Employee.API.Tests.TestData
{
    public static class Data
    {
        public static class EmployeeData
        {
            public static readonly EmployeeRequest validEmployee = new EmployeeRequest
            {
                Name = "Mary",
                Activity = true,
                Age = 29,
                Gender = Gender.Female
            };

            public static readonly EmployeeDto validEmployeeDto = new EmployeeDto
            {
                Id = 5,
                Name = "Mary",
                Activity = true,
                Age = 29,
                Gender = Gender.Female
            };

            public static readonly EmployeeDto existEmployeeDto = new EmployeeDto
            {
                Id = 3,
                Name = "Name",
                Activity = true,
                Gender = Gender.PreferNotToSay,
                Age = 34
            };
        }
    }
}