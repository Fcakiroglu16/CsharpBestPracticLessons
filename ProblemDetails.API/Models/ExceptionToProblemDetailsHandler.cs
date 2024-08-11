using System.Net;

namespace ProblemDetails.API.Models
{
    public class ExceptionToProblemDetailsHandler(IProblemDetailsService problemDetailsService)
        : Microsoft.AspNetCore.Diagnostics.IExceptionHandler
    {
        public async ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
        {
            httpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;
            return await problemDetailsService.TryWriteAsync(new ProblemDetailsContext
            {
                HttpContext = httpContext,
                ProblemDetails =
                {
                    Title = "An error occurred",
                    Detail = exception.Message,
                    Type = exception.GetType().Name,

                },
                Exception = exception
            });
        }
    }
}
