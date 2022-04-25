using Employee.API.Contracts;
using Employee.API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Employee.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class EmployeeController : ControllerBase
    {
        private readonly ILogger<EmployeeController> _logger;
        private readonly IEmployeeService _employeeService;

        public EmployeeController(ILogger<EmployeeController> logger, IEmployeeService employeeService)
        {
            _logger = logger;
            _employeeService = employeeService;
        }
        
        [HttpPost("create")]
        public IActionResult Create([FromBody] EmployeeRequest employee)
        {
            _logger.LogInformation($"Creating employee [{employee}]");
            var result = _employeeService.AddEmployee(employee);
            return result ? Ok() : Conflict();
        }
        
        [HttpPut("toggleactivity/{employeeId:int}")]
        public IActionResult ToggleActivity(int employeeId)
        {
            _logger.LogInformation($"Toggle Activity employeeId:  [{employeeId}]");
            var result = _employeeService.ToggleActivity(employeeId);
            return result ? Ok() : NotFound();
        }
    }
}