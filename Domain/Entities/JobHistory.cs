using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class JobHistory
{
    [Key]
    public DateTime Stsrt_Date { get; set; }
    public DateTime End_Date { get; set; }
    public int Job_Id { get; set; }
    public Job Job { get; set; }
    public int DepartMent_Id { get; set; }
    public DepartMent DepartMent { get; set; }

    public JobHistory()
    {
        
    }
    public JobHistory(DateTime stsrtDate, DateTime endDate)
    {
        Stsrt_Date = stsrtDate;
        End_Date = endDate;
    }
}