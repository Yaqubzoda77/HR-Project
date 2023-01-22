using Domain.Dtos;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;
[ApiController]
[Route("[controller]")]
public class CountrieController:ControllerBase
{
    private CountrieServies _countrieServies;

    public CountrieController(CountrieServies countrieServies)
    {
        _countrieServies = countrieServies;
    }

    [HttpGet("GetCountrie")]
    public async Task<List<CountrieDto>> GetACountry()
    {
        return await _countrieServies.GetACountry();
    }

    [HttpPost("AddCountrie")]
    public async Task AddCountry(CountrieDto countrieDto)
    {
        await _countrieServies.AddCountry(countrieDto);
    }

    [HttpPut("UpdateCountrie")]
    public async Task UpdateCountry( CountrieDto  countrieDto)
    {
        await _countrieServies.UpdateCountry(countrieDto);
    }

    [HttpDelete("DeleteCountrie")]
    public async Task DeleteCountry(int id)
    {
        await _countrieServies.DeleteCountry(id);
    } 
}