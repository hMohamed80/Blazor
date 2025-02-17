using Contacten.Models;
using Microsoft.EntityFrameworkCore;

namespace Contacten.Data.Models;

public class ContactenRepository : IContactenRepository
{
    private readonly AppDbContext context;
    public ContactenRepository(AppDbContext context)
    {
        this.context = context;
    }
    public async Task<Contact> AddContact(Contact contact)
    {
        var result = await context.Contacten.AddAsync(contact);
        await context.SaveChangesAsync();
        return result.Entity;
    }
    public async Task<Contact> DeleteContact(int contactId)
    {
        var result = await context.Contacten
        .FirstOrDefaultAsync(c => c.ContactId == contactId);
        if (result != null)
        {
            context.Contacten.Remove(result);
            await context.SaveChangesAsync();
            return result;
        }
        return null;
    }
    public async Task<Contact> GetContact(int contactId)
    {
        return await context.Contacten
        .FirstOrDefaultAsync(c => c.ContactId == contactId);
    }
    public async Task<IEnumerable<Contact>> GetContacten()
    {
        return await context.Contacten.ToListAsync();
    }
    public async Task<Contact> UpdateContact(Contact contact)
    {
        var result = await context.Contacten
        .FirstOrDefaultAsync(c => c.ContactId == contact.ContactId);
        if (result != null)
        {
            result.Voornaam = contact.Voornaam;
            result.Naam = contact.Naam;
            result.Adres = contact.Adres;
            result.Postcode = contact.Postcode;
            result.Gemeente = contact.Gemeente;
            result.Telefoon = contact.Telefoon;
            result.Email = contact.Email;
            result.Geboortedatum = contact.Geboortedatum;
            await context.SaveChangesAsync();
            return result;
        }
        return null;
    }
    public async Task<int> GetAantalContacten()
    {
        return await context.Contacten.CountAsync();
    }
    public async Task<IEnumerable<Contact>> GetContactenSubset(int from,
 int number)
    {
        return await context.Contacten.Skip(from).Take(number).ToListAsync();
    }
}
