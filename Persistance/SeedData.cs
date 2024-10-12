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

        public static async Task FillData(ApplicationDbContext context) {

           if(context.Country.IsNullOrEmpty()) 
           {
           using (StreamReader r = new StreamReader("../Persistance/assets/CountriesList.json"))
           {
              string json = r.ReadToEnd();
              List<Country> cs = JsonConvert.DeserializeObject<List<Country>>(json);

              await context.AddRangeAsync(cs);
              await context.SaveChangesAsync();
             }
             }
        }
        
    }
}