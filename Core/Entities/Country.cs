namespace Core.Entities;

public class Country
{
    public int Id {get; set;}
    public string Name {get; set;}
    public string Code {get; set;}
    public ICollection<Person> People {get; set;}
}
