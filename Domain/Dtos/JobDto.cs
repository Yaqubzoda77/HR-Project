namespace Domain.Dtos;

public class JobDto
{
    public int  JobId { get; set; }
    public string JobTitel { get; set; }
    public decimal MinSalary { get; set; }
    public decimal MaxSalary { get; set; }

    public JobDto(int jobId, string jobTitel, decimal minSalary, decimal maxSalary)
    {
        JobId = jobId;
        JobTitel = jobTitel;
        MinSalary = minSalary;
        MaxSalary = maxSalary;
    }
}