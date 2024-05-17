namespace WebApplication.API.ExceptionHandlers
{
    public record ResponseModel<T>(T Data, List<string> Errors);
}