namespace Domain.Entities;

public class DepartMent
{
    public int DepartMentId { get; set; }
    public string DepartmentName { get; set; }
    public int  LocationId { get; set; }
    public Location Location { get; set; }
    public  List<JobHistory> JobHistory { get; set; }



    public DepartMent()
    {
        
    }
  

    public DepartMent(int departMentId, string departmentName ,int locationId)
    {
        DepartMentId = departMentId;
        DepartmentName = departmentName;
        LocationId = locationId;
    }
}