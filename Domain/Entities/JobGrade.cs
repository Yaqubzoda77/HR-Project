using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class JobGrade
{
    [Key]
    public string GradeLevel { get; set; }
    public decimal LowestSal { get; set; }
    public decimal HighestSal { get; set; }

    public JobGrade()
    {
        
    }
    public JobGrade(string gradeLevel, decimal lowestSal, decimal highestSal)
    {
        GradeLevel = gradeLevel;
        LowestSal = lowestSal;
        HighestSal = highestSal;
    }
}