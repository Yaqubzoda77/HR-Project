using Domain.Dtos;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;
[ApiController]
[Route("[controller]")]
public class RegionController
{
    

    private RegionService _regionService;

    public RegionController(RegionService regionService)
    {
        _regionService = regionService;
    }

    [HttpGet("Getregion")]
    public async Task<List<RegionDto>> GetRegion()
    {
        return await _regionService.GetRegion();
    }

    [HttpPost("Addregion")]
    public async Task AddRegion(RegionDto regionDto)
    {
        await _regionService.AddRegion(regionDto);
    }

    [HttpPut("Updateregion")]
    public async Task UpdateRegion(RegionDto regionDto)
    {
        await _regionService.UpdateRegion(regionDto);
    }

    [HttpDelete("Deleteregion")]
    public async Task DeleteRegion(int id)
    {
        await _regionService.DeleteRegion(id);
    }
}