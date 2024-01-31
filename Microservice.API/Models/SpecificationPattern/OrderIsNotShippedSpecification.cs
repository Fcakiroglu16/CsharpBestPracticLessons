using System.Linq.Expressions;

namespace Microservice.API.Models.SpecificationPattern
{
    public class OrderIsNotShippedSpecification : Specification<Order>
    {
        public override Expression<Func<Order, bool>> ToExpression()
        {
            return order => order.ShipmentStatus != ShipmentStatus.Shipped;
        }
    }
}