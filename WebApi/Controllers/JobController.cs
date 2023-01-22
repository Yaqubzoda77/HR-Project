using Domain.Dtos;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;
[ApiController]
[Route("[controller]")]
public class JobController
{
    private JobService _jobService;

    public JobController(JobService jobService)
    {
        _jobService = jobService;
    }

    [HttpGet("GetdeJob")]
    public async Task<List<JobDto>> GetJob()
    {
        return await _jobService.GetJob();
    }

    [HttpPost("AddJob")]
    public async Task AddJob(JobDto jobDto)
    {
        await _jobService.AddJob(jobDto);
    }

    [HttpPut("UpdateJob")]
    public async Task UpdateJob(JobDto jobDto)
    {
        await _jobService.UpdateJob(jobDto);
    }

}