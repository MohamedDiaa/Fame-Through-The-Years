using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Core.Entities;

namespace Persistance;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
{
    public DbSet<Person> Person {get; set;}
    public DbSet<Country> Country {get; set;}

    public DbSet<Picture> picture {get; set;}

    protected override void OnModelCreating(ModelBuilder builder)
    {
                
          base.OnModelCreating(builder);

        builder.Entity<Person>( p =>
           {
             p.HasKey(p => p.Id);

             p.Property(e => e.Id).ValueGeneratedOnAdd();

            
             p.HasMany(p => p.pictures)
             .WithOne(p => p.Person)
             .HasForeignKey( p => p.PersonId);

             p.HasOne(p => p.Country)
             .WithMany(c => c.People)
             .HasForeignKey(p => p.CountryId);

           });

           builder.Entity<Country>( c => 
           {
            c.HasKey(c => c.Id);
            c.Property(c => c.Id)
            .ValueGeneratedOnAdd();
            });
           
        
    }

}
