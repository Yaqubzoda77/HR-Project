using Domain.Dtos;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;
[ApiController]
[Route("[controller]")]
public class DepartMentController
{


    private DepartMentService _departMentService;

    public DepartMentController(DepartMentService departMentService)
    {
        _departMentService = departMentService;
    }

    [HttpGet("GetdepartMent")]
    public async Task<List<DeepartMentDto>> GetDepartment()
    {
        return await _departMentService.GetDepartment();
    }

    [HttpPost("AddCDepartment")]
    public async Task AddDepartMent(DeepartMentDto deepartMentDto)
    {
        await _departMentService.AddDepartMent(deepartMentDto);
    }

    [HttpPut("UpdateCountrie")]
    public async Task UpdateDepartMent(DeepartMentDto deepartMentDto)
    {
        await _departMentService.UpdateDepartMent(deepartMentDto);
    }

    [HttpDelete("DeleteDepartMent")]
    public async Task DeleteDepartMents(int id)
    {
        await _departMentService.DeleteDepartMents(id);
    }
}