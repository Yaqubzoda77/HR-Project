namespace Domain.Dtos;

public class LocationDto
{
    public int Location_ID { get; set; }
    public  string Street_Addres { get; set; }
    public  string Postal_Code { get; set; }
    public string City { get; set; }
    
    public string Statte_Province { get; set; }
    public int Country_Id { get; set; }

    public LocationDto()
    {
        
    }
    public LocationDto(int locationId, string streetAddres, string postalCode, string city, string statteProvince,int country_Id)
    {
        Location_ID = locationId;
        Street_Addres = streetAddres;
        Postal_Code = postalCode;
        City = city;
        Statte_Province = statteProvince;
        Country_Id = country_Id;
    }
}