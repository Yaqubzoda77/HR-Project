using Domain.Dtos;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services;

public class JobService
{
    private readonly DataContext _context;

    public JobService (DataContext context)
    {
        _context = context;
    }

    public async Task<List<JobDto>> GetJob()
    {
        return await _context.Jobs.Select(x => new JobDto(x.JobId, x.JobTitel, x.MinSalary, x.MaxSalary)).ToListAsync();
    }

    public async Task AddJob(JobDto jobDto)
    {
        try
        {
            var add = new Job(jobDto.JobId,jobDto.JobTitel, jobDto.MinSalary, jobDto.MaxSalary);
            await _context.Jobs.AddAsync(add);
            await  _context.SaveChangesAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    
    }
    
    public async Task UpdateJob( JobDto jobDto)
    {
        try
        {
            var update = new Job(jobDto.JobId,jobDto.JobTitel, jobDto.MinSalary, jobDto.MaxSalary);
            _context.Jobs.Update(update);
            await _context.SaveChangesAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
     
    }
}