using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using LoanHouse.Client;
using LoanHouse.Client.Managers;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IUsuarioRolManager,UsuarioRolManager>();
builder.Services.AddScoped<IUsuarioManager,UsuarioManager>();
builder.Services.AddScoped<IClienteManager,ClienteManager>();
builder.Services.AddScoped<IPrestamoManager,PrestamoManager>();
await builder.Build().RunAsync();
