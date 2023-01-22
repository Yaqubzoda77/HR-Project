using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Location
{
    [Key]
    public int Location_ID { get; set; }
    public  string Street_Addres { get; set; }
    public  string Postal_Code { get; set; }
    public string City { get; set; }
    public string Statte_Province { get; set; }
    public int CountryId  { get; set; }
    public Country Country { get; set; }
    public List<DepartMent> DepartMent { get; set; }

    public Location()
    {
        
    }
    public Location(int locationId, string streetAddres, string postalCode, string city, string statteProvince,int countryId)
    {
        Location_ID = locationId;
        Street_Addres = streetAddres;
        Postal_Code = postalCode;
        City = city;
        Statte_Province = statteProvince;
        CountryId  =  countryId;
    }
}