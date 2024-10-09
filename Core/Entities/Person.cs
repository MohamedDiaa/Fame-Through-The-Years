namespace Core.Entities;

public class Person
{
    public string Id {get; set;}
    public string Name {get; set;}
    public DateOnly BirthDate {get; set;}

    public int CountryId {get; set;}
    public Country Country {get; set;}

    public ICollection<Picture> pictures {get; set;}
}
