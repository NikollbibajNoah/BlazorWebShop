using Microsoft.EntityFrameworkCore;
using WebShop.Client.Pages;
using WebShop.Components;
using WebShop.DB;
using WebShop.Implementation;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveWebAssemblyComponents()
    .AddInteractiveServerComponents(); ///!!!

///DI
builder.Services.AddSingleton<ItemsService>();
builder.Services.AddScoped<ProductService>();

///DB
builder.Services.AddDbContext<StoreDBContext>(options =>
        options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

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
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(WebShop.Client._Imports).Assembly)
    .AddInteractiveServerRenderMode(); ///!!!

app.Run();
