namespace Domain.Dtos;

public class EmployeeDto
{
    public int EmployeeId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public int PhoneNumber { get; set; }
    public DateTime Hire_Date { get; set; }
    public Decimal Salarary { get; set; }
    public int  ComissionPCT { get; set; }
    public int  JobId { get; set; }


    public EmployeeDto(int employeeId, string firstName, string lastName, string email, int phoneNumber, DateTime hireDate, decimal salarary, int comissionPct, int jobId)
    {
        EmployeeId = employeeId;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        PhoneNumber = phoneNumber;
        Hire_Date = hireDate;
        Salarary = salarary;
        ComissionPCT = comissionPct;
        JobId = jobId;
    }

    public EmployeeDto()
    {
        
    }
    
}