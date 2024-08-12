using GlobalizationAndLocalization.API.Models;
using Microsoft.AspNetCore.Localization;
using System.Globalization;
using GlobalizationAndLocalization.API;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.OperationFilter<AcceptLanguageHeaderOperationFilter>();
});

//Globalization
//var supportedCultures = new CultureInfo[] { new("en"), new("it"), new("fr") };

// Localization
var supportedCultures = new CultureInfo[] { new("en-US"), new("en-GB"), new("tr-TR"), new("de-DE") };

builder.Services.Configure<RequestLocalizationOptions>(options =>
{
    options.SupportedCultures = supportedCultures; // datetime-currency
    options.SupportedUICultures = supportedCultures; // string localization
    options.DefaultRequestCulture = new
        RequestCulture(supportedCultures.First());
});

builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");
builder.Services.AddSingleton<SharedLocalizationService>();

var app = builder.Build();

app.UseRequestLocalization();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


//QueryStringRequestCultureProvider: Searches for the culture and ui - culture query string parameters
//CookieRequestCultureProvider: Uses the ASP.NET Core cookie
//AcceptLanguageHeaderRequestProvider: Reads the requested culture from the Accept-Language HTTP header
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
