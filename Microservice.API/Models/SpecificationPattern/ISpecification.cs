namespace Microservice.API.Models.SpecificationPattern
{
    public interface ISpecification<in T>
    {
        bool IsSatisfiedBy(T item);
    }
}