using FastEndpoints;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.API.Product
{
    //[HttpPost("api/products")]
    public class ProductSaveEndpoint : Endpoint<ProductSaveRequestDto, ProductSaveResponseDto>
    {
        public override void Configure()
        {
            Post("api/products");
            AllowAnonymous();
        }

        public override async Task HandleAsync(ProductSaveRequestDto req, CancellationToken ct)
        {
            await SendAsync(new ProductSaveResponseDto(Guid.NewGuid()), cancellation: ct);
        }
    }
}