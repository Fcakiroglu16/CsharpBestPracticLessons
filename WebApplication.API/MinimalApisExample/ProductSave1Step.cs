namespace WebApplication.API.MinimalApisExample
{
    public class ProductSave1Step
    {
        public record Request(string Name, decimal Price, int Count);

        public record Response(Guid Id);

        public class Endpoint
        {
            public Response Handle(Request request)
            {
                return new Response(Guid.NewGuid());
            }
        }
    }
}