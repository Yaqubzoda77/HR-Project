namespace Domain.Entities;

public class Job
{
    public int  JobId { get; set; }
    public string JobTitel { get; set; }
    public decimal MinSalary { get; set; }
    public decimal MaxSalary { get; set; }
    public  List<Employee> Employee { get; set; }
    public  List<JobHistory> JobHistory { get; set; }

    public Job()
    {
        
    }
    public Job(int jobId, string jobTitel, decimal minSalary, decimal maxSalary)
    {
        JobId = jobId;
        JobTitel = jobTitel;
        MinSalary = minSalary;
        MaxSalary = maxSalary;
    }
}