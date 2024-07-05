using System.Runtime.CompilerServices;

namespace WebApplication.API.MinimalApisExample
{
    public static class ProductSave3Step
    {
        public record Request(string Name, decimal Price, int Count);

        public record Response(Guid Id);

        public class HandlerStep3
        {
            public Response Handle(Request request)
            {
                return new Response(Guid.NewGuid());
            }
        }

        public static IServiceCollection AddProductSave(this IServiceCollection services)
        {
            return services.AddScoped<HandlerStep3>();
            return services;
        }


        public static IEndpointRouteBuilder MapProductSave(this IEndpointRouteBuilder endpoints)
        {
            endpoints.MapPost("/products3Step",
                (Request request, HandlerStep3 handler) => { return Results.Ok(handler.Handle(request)); });
            return endpoints;
        }
    }
}