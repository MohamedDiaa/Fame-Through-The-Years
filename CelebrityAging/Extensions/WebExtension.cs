using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Persistance;

namespace CelebrityAging.Extensions
{
    public static class WebExtension
    {
        
        
        public static async Task Seed(this WebApplication app) {

          using var scope = app.Services.CreateScope();
          var context = scope.ServiceProvider.GetService<ApplicationDbContext>();
          if(context != null) 
          {
           await Persistance.SeedData.FillData(context);

            }
            return ;
        }        
    }
}