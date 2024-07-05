using FastEndpoints;
using FastEndpoints.Swagger;
using Microsoft.FeatureManagement;
using Microsoft.FeatureManagement.FeatureFilters;
using WebApplication.API.MinimalApisExample;


var builder = Microsoft.AspNetCore.Builder.WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddFastEndpoints().SwaggerDocument();

builder.Services.AddScoped<ProductSave1Step.Endpoint>();
builder.Services.AddScoped<ProductSave2Step.Handler>();

builder.Services.AddProductSave();
var app = builder.Build();

app.MapProductSave();

app.MapPost("/products1Step",
    ([AsParameters] ProductSave1Step.Request request, ProductSave1Step.Endpoint endpoint) =>
        endpoint.Handle(request)).WithName("Products");


app.MapPost("/products2Step", ProductSave2Step.Endpoint);


app.UseFastEndpoints().UseSwaggerGen();
// Configure the HTTP request pipeline.

app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();


app.Run();