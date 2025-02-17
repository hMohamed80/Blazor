using Contacten.Models;
using System.Net.Http.Json;
using System.Text.Json;

namespace Contacten.Web.Client.Services;

public class ContactenService
{
    private readonly HttpClient httpClient;
    public ContactenService(HttpClient httpClient)
    {
        this.httpClient = httpClient;
    }
    public async Task<IEnumerable<Contact>> GetContacten()
    {
        var contacten = await httpClient.GetStringAsync("api/contacten");
        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };
        return JsonSerializer.Deserialize<IEnumerable<Contact>>(
            contacten, options);
    }
    public async Task<Contact> GetContact(int id)
    {
        var contact = await httpClient.GetStringAsync($"api/contacten/{id}");
        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };
        return JsonSerializer.Deserialize<Contact>(contact, options);
    }
    public async Task<Contact> UpdateContact(Contact contact)
    {
        HttpResponseMessage message = await httpClient.PutAsJsonAsync<Contact>(
        $"api/contacten/{contact.ContactId}", contact);
        if (message.IsSuccessStatusCode)
            return contact;
        else
            return null;
    }
    public async Task DeleteContact(int id)
    {
        await httpClient.DeleteAsync($"api/contacten/{id}");
    }
    public async Task<Contact> AddContact(Contact contact)
    {
        HttpResponseMessage message = await httpClient.PostAsJsonAsync<Contact>(
        $"api/contacten", contact);
        if (message.IsSuccessStatusCode)
            return contact;
        else
            return null;
    }
    public async Task<int> GetAantalContacten()
    {
        var aantalContactenString = await
        httpClient.GetStringAsync("api/aantalcontacten");
        return JsonSerializer.Deserialize<int>(aantalContactenString)!;
    }
    public async Task<IEnumerable<Contact>> GetContactenSubset(int from,
    int number)
    {
        var contactenString = await
        httpClient.GetStringAsync($"api/contacten/{from}/{number}");
        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };
        return JsonSerializer.Deserialize<Contact[]>(contactenString, options)!;
    }
}
