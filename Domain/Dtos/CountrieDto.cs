namespace Domain.Dtos;

public class CountrieDto
{
    public int CountrieId { get; set; }
    public string CountryName { get; set; }
    public int RegionId { get; set; }

    public CountrieDto()
    {
        
    }
    public CountrieDto(int countrieId, string countryName, int regionId)
    {
        CountrieId = countrieId;
        CountryName = countryName;
        RegionId = regionId;
    }
}