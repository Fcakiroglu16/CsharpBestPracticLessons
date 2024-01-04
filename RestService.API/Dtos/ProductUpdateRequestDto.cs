namespace RestService.API.Dtos;

public record ProductUpdateRequestDto(int Id, string Name, int Stock)
{
}