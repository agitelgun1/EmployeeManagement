using Employee.API.Enums;

namespace Employee.API.Domain
{
    public class EmployeeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public int Age { get; set; }
        public bool Activity { get; set; }
    }
}