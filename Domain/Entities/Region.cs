using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Region
{
    [Key]
    public int Region_Id { get; set; }
    public string Region_Name { get; set; }
    public List<Country> Countrie { get; set; }

    public Region()
    {
        
    }
    public Region(int regionId, string regionName)
    {
        Region_Id = regionId;
        Region_Name = regionName;
    }
}