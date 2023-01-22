namespace Domain.Dtos;

public class JobGradeDto
{
    public string GradeLevel { get; set; }
    public decimal LowestSal { get; set; }
    public decimal HigestSal { get; set; }

    public JobGradeDto()
    {
        
    }
    public JobGradeDto(string gradeLevel, decimal lowestSal, decimal higestSal)
    {
        GradeLevel = gradeLevel;
        LowestSal = lowestSal;
        HigestSal = higestSal;
    }
}