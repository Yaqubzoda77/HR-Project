namespace Domain.Dtos;

public class DeepartMentDto
{
    public int DepartMentId { get; set; }
    public string DepartmentName { get; set; }
    public int  LocationId { get; set; }

    public DeepartMentDto()
    {
        
    }
    public DeepartMentDto(int departMentId, string departmentName ,int locationId)
    {
        DepartMentId = departMentId;
        DepartmentName = departmentName;
        LocationId = locationId;
    }
}