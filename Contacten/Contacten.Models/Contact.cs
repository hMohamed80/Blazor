using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacten.Models;
public class Contact
{
    public int ContactId { get; set; }
    public string Voornaam { get; set; }
    public string Naam { get; set; }
    public string Adres { get; set; }
    public string Postcode { get; set; }
    public string Gemeente { get; set; }
    public string Telefoon { get; set; }
    public string Email { get; set; }
    public DateTime Geboortedatum { get; set; }
}

