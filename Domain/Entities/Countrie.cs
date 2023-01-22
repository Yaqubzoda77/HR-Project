using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Country
{
    [Key]
    public int CountrieId { get; set; }
    public string CountryName { get; set; }

    public int RegionId  { get; set; }
    
    public Region Region { get; set; }
    public List<Location> Location { get; set; }
    public Country()
    {
        
    }
    public Country(int countrieId, string countryName,int regionId)
    {
        CountrieId = countrieId;
        CountryName = countryName;
        RegionId = regionId;
    }

   
}