namespace WebApplication.API.Product
{
    public record ProductSaveRequestDto(string Name, decimal Price, int Count);
}