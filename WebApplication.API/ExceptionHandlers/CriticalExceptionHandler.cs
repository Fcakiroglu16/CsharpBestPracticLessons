using System.Net;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.API.ExceptionHandlers
{
    internal sealed class CriticalExceptionHandler(ILogger<CriticalExceptionHandler> logger) : IExceptionHandler
    {
        public async ValueTask<bool> TryHandleAsync(
            HttpContext httpContext,
            Exception exception,
            CancellationToken cancellationToken)
        {
            logger.LogError(
                exception, "Exception occurred: {Message}", exception.Message);


            logger.LogCritical($"sms gönder. hata : {exception.Message}");

            return false;
        }
    }
}