using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft;
using Newtonsoft.Json;

namespace Persistance
{
    public static class SeedData
    {

        public static async Task FillData(ApplicationDbContext context)
        {

            if (context.Country.IsNullOrEmpty())
            {
                using (StreamReader r = new StreamReader("../Persistance/assets/CountriesList.json"))
                {
                    string json = r.ReadToEnd();
                    List<Country> cs = JsonConvert.DeserializeObject<List<Country>>(json);

                    await context.AddRangeAsync(cs);
                    await context.SaveChangesAsync();
                }
            }

            if (context.Person.IsNullOrEmpty())
            {
                using (StreamReader r = new StreamReader("../Persistance/assets/ActorsList.json"))
                {
                    string json = r.ReadToEnd();
                    List<PersonJSONObject> ps = JsonConvert.DeserializeObject<List<PersonJSONObject>>(json);
                    List<Person> personList = new();

                    foreach (var p in ps)
                    {
                        personList.Add(new Person
                        {
                            Name = p.Name,
                            BirthDate = p.Birthday,
                            Gender = p.Gender,
                            pictures = p.GetPictures(),
                            CountryId = 241
                        });

                    }

                    await context.AddRangeAsync(personList);
                    await context.SaveChangesAsync();
                }

            }
        }

    }
}

class PersonJSONObject
{

    public string Name { get; set; }
    public string? Birthday { get; set; }
    public string Gender { get; set; }
    public List<string> Pictures { get; set; }

    public List<Picture> GetPictures()
    {
        List<Picture> pics = new();
        foreach (var item in Pictures)
        {
            pics.Add(
            new Picture
            {
                Link = item
            }
            );
        }
        return pics;
    }
}