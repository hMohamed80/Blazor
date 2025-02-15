using Contacten.Web.Client.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddTransient<ContactenService>();
builder.Services.AddSingleton(
new HttpClient { BaseAddress = new Uri("https://localhost:7194/") });
await builder.Build().RunAsync();
