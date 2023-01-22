using Domain.Dtos;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;
[ApiController]
[Route("[controller]")]
public class JobGradeConroller
{
    private JobGradeService _jobGradeService;

    public JobGradeConroller(JobGradeService jobGradeService)
    {
        _jobGradeService = jobGradeService;
    }

    [HttpGet("GetJobGrade")]
    public async Task<List<JobGradeDto>> GetJobGrade()
    {
        return await _jobGradeService.GetJobGrade();
    }

    [HttpPost("AddJobGrade")]
    public async Task AddJobGrade(JobGradeDto jobGradeDto)
    {
        await _jobGradeService.AddJobGrade(jobGradeDto);
    }

    [HttpPut("UpdateJobGrade")]
    public async Task UpdateJobGrade(JobGradeDto jobGradeDto)
    {
        await _jobGradeService.UpdateJobGrade(jobGradeDto);
    }
    
}