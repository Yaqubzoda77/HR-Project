using Domain.Dtos;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services;
[Keyless]

    public class JobGradeService
{
    private readonly DataContext _context;

    public JobGradeService (DataContext context)
    {
        _context = context;
    }

    public async Task<List<JobGradeDto>> GetJobGrade()
    {
        return await _context.JobGrades.Select(x => new JobGradeDto(x.GradeLevel, x.LowestSal, x.HighestSal)).ToListAsync();
    }

    public async Task AddJobGrade(JobGradeDto jobGradeDto)
    {
        var add = new JobGrade(jobGradeDto.GradeLevel, jobGradeDto.LowestSal, jobGradeDto.HigestSal);
        await _context.JobGrades.AddAsync(add);
        await  _context.SaveChangesAsync();
    }
    
    public async Task UpdateJobGrade( JobGradeDto jobGradeDto)
    {
        try
        {
            var update = new JobGrade(jobGradeDto.GradeLevel, jobGradeDto.LowestSal, jobGradeDto.HigestSal);
            _context.JobGrades.Update(update);
            await _context.SaveChangesAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
       
    }

   
}