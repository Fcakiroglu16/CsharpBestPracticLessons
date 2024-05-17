using FastEndpoints;
using FastEndpoints.Swagger;
using Microsoft.FeatureManagement;
using Microsoft.FeatureManagement.FeatureFilters;
using WebApplication.API.Middlewares;


var builder = Microsoft.AspNetCore.Builder.WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();

app.UseAuthorization();
app.UseMiddleware<EmojiMiddleware>();
app.MapControllers();


app.Run();