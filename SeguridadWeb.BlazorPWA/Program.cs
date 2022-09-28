using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SeguridadWeb.BlazorPWA;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// https://localhost:44370/api/Rol
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:44370/api/") });

await builder.Build().RunAsync();
