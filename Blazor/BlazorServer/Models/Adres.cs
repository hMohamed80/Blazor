using System.ComponentModel.DataAnnotations;

namespace BlazorServer.Models;

public class Adres
{
    [Required(ErrorMessage = "Straat en nummer is een verplicht veld")]
    public string StraatEnNr { get; set; }
    [Required(ErrorMessage = "{0} is een verplicht veld")]
    public string Postcode { get; set; }
    [Required(ErrorMessage = "{0} is een verplicht veld")]
    public string Gemeente { get; set; }
}
