using BlazorServer.Models;
using BlazorServer.Validators;
using System.ComponentModel.DataAnnotations;

namespace BlazorServer.ViewModels;

public class UserViewModel
{
    [Required(ErrorMessage = "{0} is een verplicht veld")]
    [StringLength(30, ErrorMessage =
 "Gebruik maximum {1} tekens voor het veld {0}")]
    public string Voornaam { get; set; }
    [Required(ErrorMessage = "{0} is een verplicht veld")]
    [StringLength(30, ErrorMessage =
    "Gebruik maximum {1} tekens voor het veld {0}")]
    public string Familienaam { get; set; }
    [GeboortedatumValidator(ErrorMessage =
 "Geboortedatum moet in het verleden liggen")]
    public DateTime GeboorteDatum { get; set; }
    public string Opleidingscentrum { get; set; }
    public bool Rijbewijs { get; set; }
    public Finaliteit Finaliteit { get; set; }
    public string Email { get; set; }
    [Compare("Email", ErrorMessage = "Email en ConfirmEmail zijn verschillend")]
    public string ConfirmEmail { get; set; }
    [ValidateComplexType]
    public Adres Adres { get; set; } = new Adres();
}
