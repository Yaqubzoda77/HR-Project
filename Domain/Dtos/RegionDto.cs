namespace Domain.Dtos;

public class RegionDto
{
    public int Region_Id { get; set; }
    public string Region_Name { get; set; }

    public RegionDto(int regionId, string regionName)
    {
        Region_Id = regionId;
        Region_Name = regionName;
    }

    public RegionDto()
    {
        
    }
}