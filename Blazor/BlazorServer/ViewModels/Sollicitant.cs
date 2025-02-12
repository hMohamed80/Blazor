using BlazorServer.Validators;
using System.ComponentModel.DataAnnotations;

namespace BlazorServer.ViewModels;

public class Sollicitant
{
    [Required(ErrorMessage = "{0} is een verplicht veld")]
    [StringLength(30, ErrorMessage =
 "Gebruik maximum {1} tekens voor het veld {0}")]
    public string Naam { get; set; }
    [Required(ErrorMessage = "{0} is een verplicht veld")]
    [StringLength(30, ErrorMessage =
    "Gebruik maximum {1} tekens voor het veld {0}")]
    public string Voornaam { get; set; }
    [GeboortedatumValidator(ErrorMessage =
    "Geboortedatum moet in het verleden liggen")]
    public DateTime GeboorteDatum { get; set; }
    public bool Rijbewijs { get; set; }
    [Required(ErrorMessage = "{0} is een verplicht veld")]
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; }
    public Diploma Diploma { get; set; }
    [Required(ErrorMessage = "{0} is een verplicht veld")]
    public string Functie { get; set; }
}
