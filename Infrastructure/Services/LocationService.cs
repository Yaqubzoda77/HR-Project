using Domain.Dtos;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services;

public class LocationService
{
    private readonly DataContext _context;

    public LocationService(DataContext context)
    {
        _context = context;
    }

    public async Task<List<LocationDto>> GetLocation()
    {
        return await _context.Locations.Select(x => new LocationDto
                (x.Location_ID, x.Street_Addres, x.Postal_Code, x.City, x.Statte_Province,x.CountryId)).ToListAsync();
    }

    public async Task AddLocation(LocationDto locationDto)
    {
        try
        {
            var add = new Location()
            {
                Location_ID = locationDto.Location_ID,
                City = locationDto.City,
                CountryId = locationDto.Country_Id,
                Postal_Code = locationDto.Postal_Code,
                Statte_Province = locationDto.Statte_Province,
                Street_Addres = locationDto.Street_Addres
            
            };
            await _context.Locations.AddAsync(add);
            await _context.SaveChangesAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
        }
    
   

        public async Task UpdateLocation(LocationDto locationDto)
        {
            try
            {
                var update = new Location(locationDto.Location_ID, locationDto.Street_Addres, locationDto.Postal_Code,locationDto.City, locationDto.Statte_Province,locationDto.Country_Id);
                _context.Locations.Update(update);
                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        public async Task DeleteLocations(int id)
        {
            var delete = await _context.Locations.FirstAsync(x => x.Location_ID == id);
            _context.Locations.Remove(delete);
            await _context.SaveChangesAsync();
        }
    }
