using Microsoft.JSInterop;

namespace BlazorServer.Models;

public class Groeter
{
    public Groeter(string naam)
    {
        Naam = naam;
    }
    public string Naam { get; set; }
    [JSInvokable]
    public string Begroet() => $"Hallo, {Naam}!";
}
