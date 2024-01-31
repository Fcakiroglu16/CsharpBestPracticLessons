using Microservice.API.Models;
using Microservice.API.Models.SpecificationPattern;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Microservice.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController(AppDbContext dbContext) : ControllerBase
    {
        private readonly AppDbContext _dbContext = dbContext;

        [HttpGet]
        public IActionResult Get()
        {
            var orderIsCancelled = new OrderIsCancelledSpecification();
            var orderIsNotShipped = new OrderIsNotShippedSpecification();

            var orders = _dbContext.Orders.Where(orderIsCancelled.Or(orderIsNotShipped).IsSatisfiedBy).ToList();

            return Ok(orders);
        }
    }
}