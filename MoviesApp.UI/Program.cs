global using ApiClient;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MoviesApp.UI;
using MoviesApp.UI.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddScoped<IActorService, ActorService>();
builder.Services.AddScoped<IAgentService, AgentService>();

#region Upadate Services
builder.Services.AddScoped<IActorUpdateService, ActorUpdateService>();
#endregion
await builder.Build().RunAsync();
