namespace Core;

public class Picture
{
    public int Id {get; set;}
    public DateOnly? CapturedDate {get; set;}

    public string PersonId {get; set;}
    public Person person {get; set;}

}
