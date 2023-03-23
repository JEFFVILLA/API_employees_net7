using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using API.Dtos.Employeer;
using API.Models;
using API.Services.EmployeeService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeerService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeerService = employeeService;
        }


        [HttpGet("Getall")]
        public async Task<ActionResult<List<GetEmployeerDto>>> GetAllEmployeers()
        {
            int userId = int.Parse(User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)!.Value);
            var response = await _employeerService.GetAllEmployees(userId);
            if (response is null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }

        
        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<GetEmployeerDto>>> GetSingle(int id)
        {
            return Ok(await _employeerService.GetSingleEmployee(id));
        }

        [HttpPost("CreateEmployeer")]
        public async Task<ActionResult<ServiceResponse<GetEmployeerDto>>> CreateEmployeer(Employeer newEmployeer)
        {
            return Ok(await _employeerService.CreateEmployee(newEmployeer));
        }

    }
}