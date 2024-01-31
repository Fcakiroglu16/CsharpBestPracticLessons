namespace Microservice.API.Models.SpecificationPattern
{
    public class AndSpecification<T>(ISpecification<T> left, ISpecification<T> right) : ISpecification<T>
    {
        public bool IsSatisfiedBy(T item)
        {
            return left.IsSatisfiedBy(item) && right.IsSatisfiedBy(item);
        }
    }
}