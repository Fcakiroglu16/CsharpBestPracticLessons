using Microservice.API.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<AppDbContext>(options => options.UseInMemoryDatabase("app-database"));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();


    var order = new Order
    {
        Status = OrderStatus.Cancelled,
        ShipmentStatus = ShipmentStatus.Shipped
    };
    var order2 = new Order()
    {
        Status = OrderStatus.Cancelled,
        ShipmentStatus = ShipmentStatus.NotShipped
    };

    context.Orders.Add(order);
    context.Orders.Add(order2);
    context.SaveChanges();
}


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
}

app.UseSwagger();
app.UseSwaggerUI();
//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();