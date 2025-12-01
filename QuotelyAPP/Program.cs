using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using QuotelyAPP;
using QuotelyAPP.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient{BaseAddress = new Uri("https://api.quotable.io/")});

builder.Services.AddScoped<QuoteService>();
builder.Services.AddScoped<FavoritesService>();
await builder.Build().RunAsync();
