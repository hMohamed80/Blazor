using System.ComponentModel.DataAnnotations;

namespace BlazorServer.Models;

public class Boodschap
{
    [Required]
    [MaxLength(20)]
    public string Naam { get; set; }
    [Required]
    public string Tekst { get; set; }
}
