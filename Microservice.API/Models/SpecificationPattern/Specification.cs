using System.Linq.Expressions;

namespace Microservice.API.Models.SpecificationPattern
{
    public abstract class Specification<T> : ISpecification<T>
    {
        public bool IsSatisfiedBy(T item)
        {
            var predicate = ToExpression().Compile();

            return predicate(item);
        }

        public abstract Expression<Func<T, bool>> ToExpression();

        public ISpecification<T> And(ISpecification<T> specification)
        {
            return new AndSpecification<T>(this, specification);
        }

        public ISpecification<T> Or(ISpecification<T> specification)
        {
            return new OrSpecification<T>(this, specification);
        }
    }
}