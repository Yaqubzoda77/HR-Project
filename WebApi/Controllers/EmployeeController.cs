using Domain.Dtos;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;
[ApiController]
[Route("[controller]")]
public class EmployeeController
{
    private EmployeeService _employeeService;

    public EmployeeController(EmployeeService employeeService)
    {
        _employeeService = employeeService;
    }

    [HttpGet("GetdeEmployee")]
    public async Task<List<EmployeeDto>> GetDEmployee()
    {
        return await _employeeService.GetDEmployee();
    }

    [HttpPost("AddCDEmployee")]
    public async Task AddEmployee(EmployeeDto employeeDto)
    {
        await _employeeService.AddEmployee(employeeDto);
    }

    [HttpPut("UpdateEmployee")]
    public async Task UpdateEmployee(EmployeeDto employeeDto)
    {
        await _employeeService.UpdateEmployee(employeeDto);
    }

    [HttpDelete("DeleteEmployee")]
    public async Task DeleteEmployee(int id)
    {
        await _employeeService.DeleteEmployee(id);
    }
}