namespace WebApplication.API.ExceptionHandlers
{
    public class CriticalException(string message) : Exception(message);
}