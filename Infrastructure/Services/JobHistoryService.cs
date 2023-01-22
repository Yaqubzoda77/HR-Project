using Domain.Dtos;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services;

public class JobHistoryService
{
    private readonly DataContext _context;

    public JobHistoryService(DataContext context)
    {
        _context = context;
    }

    public async Task<List<JobHistoryDto>> GetJobHistory()
    {
        return await _context. JobHistorys.Select(x => new JobHistoryDto(x.Stsrt_Date, x.End_Date)).ToListAsync();
    }

    public async Task AddJobHistory(JobHistoryDto jobHistory)
    {
        try
        {
            var add = new JobHistory(jobHistory.Stsrt_Date, jobHistory.End_Date);
            await _context.JobHistorys.AddAsync(add);
            await  _context.SaveChangesAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
      
    }
    
    public async Task UpdateJobHistory(JobHistoryDto jobHistory)
    {
        try
        {
            var update = new JobHistory (jobHistory.Stsrt_Date, jobHistory.End_Date );
            _context.JobHistorys.Remove(update);
            await _context.SaveChangesAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
       
    }

 
}