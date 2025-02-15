using Contacten.Models;

namespace Contacten.Data.Models;

public interface IContactenRepository
{
    Task<IEnumerable<Contact>> GetContacten();
    Task<Contact> GetContact(int contactId);
    Task<Contact> AddContact(Contact contact);
    Task<Contact> UpdateContact(Contact contact);
    Task<Contact> DeleteContact(int contactId);

}
