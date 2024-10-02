using BlazorGetTest.Client.Pages;
using BlazorGetTest.Client.Services;
using BlazorGetTest.Components;
using BlazorGetTest.Components.Handler;
using Refit;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();

builder.Services.AddRefitClient<IGetApi>()
    .ConfigureHttpClient(c => c.BaseAddress = new Uri("https://api.adviceslip.com"))
    .AddHttpMessageHandler(() => new LoggingHandler());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();


app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(BlazorGetTest.Client._Imports).Assembly);

app.MapControllers();
app.Run();
