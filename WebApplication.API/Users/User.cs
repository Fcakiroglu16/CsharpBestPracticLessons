namespace WebApplication.API.Users
{
    public record UserCreatedRequestDto(string Name, string Email, string Password, string Role);
}