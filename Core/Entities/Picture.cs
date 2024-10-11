
using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class Picture
{
    public int Id {get; set;}
    public DateOnly? CapturedDate {get; set;}

    public string PersonId {get; set;}
    public Person Person {get; set;}

    [Url]
    public string Link {get; set;}

}
