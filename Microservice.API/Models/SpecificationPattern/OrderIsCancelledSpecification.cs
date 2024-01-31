using System.Linq.Expressions;

namespace Microservice.API.Models.SpecificationPattern
{
    public class OrderIsCancelledSpecification : Specification<Order>
    {
        public override Expression<Func<Order, bool>> ToExpression()
        {
            return (order) => order.Status == OrderStatus.Cancelled;
        }
    }
}