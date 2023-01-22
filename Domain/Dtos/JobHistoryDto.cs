namespace Domain.Dtos;

public class JobHistoryDto
{
    public DateTime Stsrt_Date { get; set; }
    public DateTime End_Date { get; set; }

    public JobHistoryDto(DateTime stsrtDate, DateTime endDate)
    {
        Stsrt_Date = stsrtDate;
        End_Date = endDate;
    }
}