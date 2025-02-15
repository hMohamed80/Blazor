using Contacten.Models;
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
}
