namespace Domain.Entities;

public class Employee
{
    public int EmployeeId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public int PhoneNumber { get; set; }
    public DateTime HireDate { get; set; }
    public Decimal Salarary { get; set; }
    public int  Comission_PCT { get; set; }
    public int  JobId { get; set; }
    public Job Job { get; set; }
    

    public Employee()
    {
        
    }
    public Employee(int employeeId, string firstName, string lastName, string email, int phoneNumber, DateTime hireDate, decimal salarary, int comissionPct ,int jobId  )
    {
        EmployeeId = employeeId;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        PhoneNumber = phoneNumber;
        HireDate = hireDate;
        Salarary = salarary;
        Comission_PCT = comissionPct;
        JobId = jobId;
    }
}