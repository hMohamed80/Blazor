using Microsoft.AspNetCore.Components;

namespace BlazorServer.Components.Pages;

public partial class Dobbelen
{
    private int currentScore = 0;
    private List<int> stenen = new List<int>();
    [Parameter]
    public int Aantal { get; set; }
    private void GooiStenen()
    {
        currentScore = 0;
        stenen.Clear();
        Random random = new Random();
        for (var index = 0; index < Aantal; index++)
        {
            var ogen = random.Next(1, 7);
            stenen.Add(ogen);
            currentScore += ogen;
        }
    }
    protected override void OnInitialized()
    {
        base.OnInitialized();
        if (Aantal == 0) Aantal = 2;
    }
}
