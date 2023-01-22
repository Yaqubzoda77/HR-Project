using Domain.Dtos;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services;

public class DepartMentService
{

    private readonly DataContext _context;

    public DepartMentService(DataContext context)
    {
        _context = context;
    }

    public async Task<List<DeepartMentDto>> GetDepartment()
    {
        return await _context.DepartMents.Select(x => new DeepartMentDto(x.DepartMentId, x.DepartmentName,x.LocationId)).ToListAsync();
    }

    public async Task AddDepartMent(DeepartMentDto deepartMentDto)
    {
        try
        {
            var add = new DepartMent(deepartMentDto.DepartMentId, deepartMentDto.DepartmentName,deepartMentDto.LocationId);
            await _context.DepartMents.AddAsync(add);
            await  _context.SaveChangesAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
      
    }
    
    public async Task UpdateDepartMent(DeepartMentDto deepartMentDto)
    {
        try
        {
            var update = new DepartMent(deepartMentDto.DepartMentId, deepartMentDto.DepartmentName  ,deepartMentDto.LocationId );
            _context.DepartMents.Update(update);
            await _context.SaveChangesAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
     
    }

    public async Task DeleteDepartMents(int id)
    {
        var delete =await _context.DepartMents.FirstAsync(x => x.DepartMentId == id); 
        _context.DepartMents.Remove(delete);
        await _context.SaveChangesAsync();
    }
    
    
}