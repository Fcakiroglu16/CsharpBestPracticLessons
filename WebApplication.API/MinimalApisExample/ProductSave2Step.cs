namespace WebApplication.API.MinimalApisExample
{
    public class ProductSave2Step
    {
        public record Request(string Name, decimal Price, int Count);

        public record Response(Guid Id);

        public class Handler
        {
            public Response Handle(Request request)
            {
                return new Response(Guid.NewGuid());
            }
        }

        public static Response Endpoint([AsParameters] Request request, Handler handler) => handler.Handle(request);
    }
}