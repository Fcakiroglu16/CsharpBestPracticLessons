using ProblemDetails.API.Models;
using System.Diagnostics;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddProblemDetails(options =>
{

    options.CustomizeProblemDetails = ctx =>
    {
        //ctx.ProblemDetails.Extensions.Add("trace-id", Activity.Current?.TraceId.ToString());
        //ctx.ProblemDetails.Extensions.Add("instance", $"{ctx.HttpContext.Request.Method} {ctx.HttpContext.Request.Path}");

        
       // setup.IncludeExceptionDetails = (ctx, env) => CurrentEnvironment.IsDevelopment() || CurrentEnvironment.IsStaging();
    };

});
builder.Services.AddExceptionHandler<ExceptionToProblemDetailsHandler>();
var app = builder.Build();
app.UseExceptionHandler();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
