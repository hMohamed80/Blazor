using Microsoft.AspNetCore.Components;

namespace BlazorServer.Components.Pages;

public class EenentwintigBase : ComponentBase
{
    protected int currentScore = 0;
    protected List<string> kaarten = new List<string>();
    private static readonly string[] Soorten = { "H", "D", "C", "S" };
    private static readonly string[] Beelden = { "7", "8", "9", "10",
                                                 "J", "Q", "K", "A" };
    private static readonly byte[] Waarden = { 7, 8, 9, 10, 1, 2, 3, 11 };

    protected CopyrightFooter? cfdynamic;
    private string GetRandomCard()
    {
        Random random = new Random();
        var soort = Soorten[random.Next(0, 4)];
        var kaart = random.Next(0, 8);
        var beeld = Beelden[kaart];
        var waarde = Waarden[kaart];
        currentScore += waarde;
        return $"{beeld}{soort}";
    }
    protected Dictionary<string, object> footerAttributes =
     new Dictionary<string, object>() {
         {
            "auteur", "Hamdan"
         },
         {
            "cursus", "Blazor"
         },
         {
            "jaartal", 2025
         },
         {
            "doelgroep", ".NET ontwikkeling met C#"
         },
     };
    protected void Verander() => footerAttributes["auteur"] = "Alina";

    protected string? cursus;
    protected string? info;
    protected void InfoOphalen()
    {
        cursus = cfdynamic?.Cursus;
        info = cfdynamic?.AlleInfo();
    }

    protected void TrekKaart()
    {
        kaarten.Add(GetRandomCard());
        //if (currentScore > 21)
        //{
        //    throw new InvalidOperationException("Je bent verbrand!");
        //}
    }
    protected override bool ShouldRender()
    {
        return currentScore <= 21;
    }
}
