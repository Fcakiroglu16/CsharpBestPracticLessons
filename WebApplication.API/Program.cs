using FastEndpoints;
using FastEndpoints.Swagger;
using Microsoft.FeatureManagement;
using Microsoft.FeatureManagement.FeatureFilters;


var builder = Microsoft.AspNetCore.Builder.WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddFastEndpoints().SwaggerDocument();
var app = builder.Build();
app.UseFastEndpoints().UseSwaggerGen();
// Configure the HTTP request pipeline.

app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();


app.Run();