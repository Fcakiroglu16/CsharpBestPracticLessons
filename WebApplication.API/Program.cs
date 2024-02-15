using Microsoft.FeatureManagement;
using Microsoft.FeatureManagement.FeatureFilters;
using WebApplication.API.Models;

var builder = Microsoft.AspNetCore.Builder.WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddFeatureManagement().AddFeatureFilter<PercentageFilter>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
}

app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();


app.MapGet("api/right-menu-show", async (IFeatureManager featureManager) =>
{
    var isRightMenuShow = await featureManager.IsEnabledAsync(FeatureFlags.IsRightMenuShow);

    return Results.Ok(isRightMenuShow);
});

app.MapGet("api/show-menu-preview", async (IFeatureManager featureManager) =>
{
    var isRightMenuShow = await featureManager.IsEnabledAsync(FeatureFlags.IsShowMenuPreview);

    return Results.Ok(isRightMenuShow);
});

app.Run();