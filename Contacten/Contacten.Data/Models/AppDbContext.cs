using Contacten.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace Contacten.Data.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Contact>().HasData(
        new Contact
        {
            ContactId = 1,
            Voornaam = "Jesse",
            Naam = "James",
            Adres = "Somersstraat 22",
            Postcode = "2018",
            Gemeente = "Antwerpen",
            Telefoon = "032021711",
            Email = "jesse.james@vdab.be",
            Geboortedatum = new DateTime(1966, 1, 1)
        });
        modelBuilder.Entity<Contact>().HasData(
        new Contact
        {
            ContactId = 2,
            Voornaam = "Jane",
            Naam = "Calamity",
            Adres = "Interleuvenlaan 2",
            Postcode = "3001",
            Gemeente = "Heverlee",
            Telefoon = "016380000",
            Email = "jane.calamity@vdab.be",
            Geboortedatum = new DateTime(1967, 2, 2)
        });
        modelBuilder.Entity<Contact>().HasData(
        new Contact
        {
            ContactId = 3,
            Voornaam = "Billy",
            Naam = "The Kid",
            Adres = "Vlamingstraat 10",
            Postcode = "8560",
            Gemeente = "Wevelgem",
            Telefoon = "056438080",
            Email = "billy.thekid@vdab.be",
            Geboortedatum = new DateTime(1968, 3, 3)
        });
        modelBuilder.Entity<Contact>().HasData(
        new Contact
        {
            ContactId = 4,
            Voornaam = "Sarah",
            Naam = "Bernhardt",
            Adres = "Industrieweg 50",
            Postcode = "9032",
            Gemeente = "Wondelgem",
            Telefoon = "092541111",
            Email = "sarah.bernhardt@vdab.be",
            Geboortedatum = new DateTime(1969, 4, 4)
        });
    }
    public DbSet<Contact> Contacten { get; set; }

}
