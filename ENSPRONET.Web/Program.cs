using ENSPRONET.Domains.Domains;
using ENSPRONET.Services.Context;
using ENSPRONET.Services.Services.Common.Interfaces;
using ENSPRONET.Services.Services.Country;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();


#region IOC

builder.Services.AddTransient<ICountryReadService, CountryService>();
builder.Services.AddTransient<ICountryCreateService, CountryService>();
builder.Services.AddTransient<ISeederService<Country>, CountryService>();
builder.Services.AddDbContext<ENSPRONETContext>();
#endregion


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html"); ;

app.Run();
