using Domain.Dtos;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;
[ApiController]
[Route("[controller]")]
public class LocationController:ControllerBase
{
        private LocationService _locationService;

        public LocationController(LocationService locationService)
        {
            _locationService = locationService;
        }

        [HttpGet("Getcc")]
        public async Task<List<LocationDto>> GetLocation()
        {
            return await _locationService.GetLocation();
        }

        [HttpPost("AddLocation")]
        public async Task AddLocation(LocationDto locationDto)
        {
            await _locationService.AddLocation(locationDto);
        }

        [HttpPut("UpdateLocation")]
        public async Task UpdateLocation(LocationDto locationDto)
        {
            await _locationService.UpdateLocation(locationDto);
        }

        [HttpDelete("DeleteLocation")]
        public async Task DeleteLocations(int id)
        {
            await _locationService.DeleteLocations(id);
        } 
}