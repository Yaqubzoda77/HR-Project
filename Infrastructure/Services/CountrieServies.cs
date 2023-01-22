using Domain.Dtos;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace Infrastructure.Services;
[Keyless]
public class CountrieServies
{
    private readonly DataContext _context;

    public CountrieServies(DataContext context)
    {
        _context = context;
    }

    public async Task<List<CountrieDto>> GetACountry()
    {
        return await _context.Countrys.Select(x => new CountrieDto(x.CountrieId, x.CountryName,x.RegionId)).ToListAsync();
    }

    public async Task AddCountry(CountrieDto countrieDto)
    {
        try
        {
            var add = new Country(countrieDto.CountrieId, countrieDto.CountryName,countrieDto.RegionId);
            await _context.Countrys.AddAsync(add);
            await  _context.SaveChangesAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
        
    }
    
    public async Task UpdateCountry(CountrieDto countrieDto)
    {
        try
        {
            var update = new Country(countrieDto.CountrieId, countrieDto.CountryName ,countrieDto.RegionId);
            _context.Countrys.Update(update);
            await _context.SaveChangesAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
       
    }

    public async Task DeleteCountry(int id)
    {
        var delete =await _context.Countrys.FirstAsync(x => x.CountrieId == id); 
        _context.Countrys.Remove(delete);
        await _context.SaveChangesAsync();
    }
}