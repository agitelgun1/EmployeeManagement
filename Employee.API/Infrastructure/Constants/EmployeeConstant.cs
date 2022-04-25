using System.Collections.Generic;
using Employee.API.Domain;
using Employee.API.Enums;

namespace Employee.API.Infrastructure.Constants
{
    public static class EmployeeConstant
    {
        public static readonly List<EmployeeDto> List = new()
        {
            new EmployeeDto
            {
                Id = 1,
                Name = "Agit",
                Activity = true,
                Gender = Gender.Male,
                Age = 29
            },
            new EmployeeDto
            {
                Id = 2,
                Name = "Mary",
                Activity = true,
                Gender = Gender.Female,
                Age = 23
            },
            new EmployeeDto
            {
                Id = 3,
                Name = "Name",
                Activity = true,
                Gender = Gender.PreferNotToSay,
                Age = 34
            }
        };
    }
}