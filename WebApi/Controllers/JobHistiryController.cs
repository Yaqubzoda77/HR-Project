using Domain.Dtos;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class JobHistiryController
{
    private JobHistoryService _jobHistoryService;

    public JobHistiryController(JobHistoryService jobHistoryService)
    {
        _jobHistoryService = jobHistoryService;
    }

    [HttpGet("GetJobHistory")]
    public async Task<List<JobHistoryDto>> GetJobHistory()
    {
        return await _jobHistoryService.GetJobHistory();
    }

    [HttpPost("AddJobHistory")]
    public async Task AddJobHistory(JobHistoryDto jobHistoryDto)
    {
        await _jobHistoryService.AddJobHistory(jobHistoryDto);
    }

    [HttpPut("UpdateJobHistory")]
    public async Task UpdateJobHistory(JobHistoryDto jobHistoryDto)
    {
        await _jobHistoryService.UpdateJobHistory(jobHistoryDto);
    }

 
}