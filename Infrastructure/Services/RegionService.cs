using Domain.Dtos;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services;

public class RegionService
{

    private readonly DataContext _context;

    public RegionService(DataContext context)
    {
        _context = context;
    }

    public async Task<List<RegionDto>> GetRegion()
    {

return await _context.Regions.Select(x => new RegionDto(x.Region_Id, x.Region_Name)).ToListAsync();
    }

    public async Task AddRegion(RegionDto regionDto)
    {
        try
        {
            var add = new Region(regionDto.Region_Id, regionDto.Region_Name);
            await _context.Regions.AddAsync(add);
            await  _context.SaveChangesAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }
    
    public async Task UpdateRegion(RegionDto regionDto)
    {
        try
        {
            var update = new Region(regionDto.Region_Id, regionDto.Region_Name );
            _context.Regions.Update(update);
            await _context.SaveChangesAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }

    public async Task DeleteRegion(int id)
    {
        var delete = await _context.Regions.FirstAsync(x => x.Region_Id == id); 
        _context.Regions.Remove(delete);
        await _context.SaveChangesAsync();
    }
}