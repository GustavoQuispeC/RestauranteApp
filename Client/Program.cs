
using Blazored.SessionStorage;
using Blazored.Toast;
using CurrieTechnologies.Razor.SweetAlert2;
using RestauranteApp.Client;

using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using RestauranteApp.Client.Autorizacion;



var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");


builder.Services.AddSingleton(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddBlazoredSessionStorage();

builder.Services.AddBlazoredToast();//para mostrar mensajes emergentes al ususario

builder.Services.AddSweetAlert2();

// Scoped = Por sesion


// Habilitamos el contexto de seguridad de Blazor
builder.Services.AddScoped<AuthenticationStateProvider, AuthenticacionService>();
builder.Services.AddAuthorizationCore();


await builder.Build().RunAsync();
