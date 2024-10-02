using BlazorGetTest.Client.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Refit;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddRefitClient<IGetApi>()
    .ConfigureHttpClient(c => c.BaseAddress = new Uri("https://api.adviceslip.com"));



await builder.Build().RunAsync();
