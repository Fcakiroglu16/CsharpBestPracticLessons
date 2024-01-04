using Microsoft.AspNetCore.Mvc;
using RestService.API.Dtos;
using RestService.API.Models;

namespace RestService.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductsController(AppDbContext context) : ControllerBase
{
    [HttpPut]
    public async Task<IActionResult> Update(ProductUpdateRequestDto request)
    {
        var product = await context.Products.FindAsync(request.Id);

        if (product is null) return NotFound();

        context.Entry(product).CurrentValues.SetValues(request);

        await context.SaveChangesAsync();
        return NoContent();
    }
}