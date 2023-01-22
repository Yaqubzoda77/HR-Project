using Domain.Dtos;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services;

public class EmployeeService
{
 private readonly DataContext _context;

    public EmployeeService(DataContext context)
    {
        _context = context;
    }

    public async Task<List<EmployeeDto>> GetDEmployee()
    {
        return await _context.Employees.Select(x => new EmployeeDto
            (x.EmployeeId, x.FirstName,x.LastName,x.Email,x.PhoneNumber,x.HireDate,x.Salarary,x.Comission_PCT,x.JobId))
            .ToListAsync();
    }

    public async Task AddEmployee(EmployeeDto employeeDto)
    {
        try
        {
            var add = new Employee(employeeDto.EmployeeId,employeeDto.FirstName,employeeDto.LastName,employeeDto.Email,employeeDto.PhoneNumber,employeeDto.Hire_Date,employeeDto.Salarary,employeeDto.ComissionPCT,employeeDto.JobId );
            await _context.Employees.AddAsync(add);
            await  _context.SaveChangesAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
      
    }
    
    public async Task UpdateEmployee(EmployeeDto employeeDto)
    {

        try
        {
            var update = new Employee(employeeDto.EmployeeId,employeeDto.FirstName,employeeDto.LastName,employeeDto.Email,employeeDto.PhoneNumber,employeeDto.Hire_Date,employeeDto.Salarary,employeeDto.ComissionPCT,employeeDto.JobId );
            _context.Employees.Update(update);
            await _context.SaveChangesAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
        
    }

    public async Task DeleteEmployee(int id)
    {
        var delete =await _context.Employees.FirstAsync(x => x.EmployeeId == id); 
        _context.Employees.Remove(delete);
        await _context.SaveChangesAsync();
    }
    
    
}