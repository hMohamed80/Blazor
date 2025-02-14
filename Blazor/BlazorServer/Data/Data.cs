using BlazorServer.Models;
using Microsoft.JSInterop;

namespace BlazorServer.Data;

public class Data
{
    private static List<Persoon> personen = new List<Persoon> {
 new Persoon { Id = 1, Voornaam = "Jesse", Familienaam = "James" },
 new Persoon { Id = 2, Voornaam = "Jane", Familienaam = "Calamity" }
 };
    [JSInvokable]
    public static List<Persoon> GetPersonen()
    {
        return personen;
    }

}
