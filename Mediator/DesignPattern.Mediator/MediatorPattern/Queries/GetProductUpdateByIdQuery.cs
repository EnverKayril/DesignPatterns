using DesignPattern.Mediator.MediatorPattern.Results;
using MediatR;

namespace DesignPattern.Mediator.MediatorPattern.Queries
{
    public class GetProductUpdateByIdQuery : IRequest<UpdateProductByIdQueryResult>
    {
        public GetProductUpdateByIdQuery(int productId)
        {
            ProductId = productId;
        }

        public int ProductId { get; set; }
    }
}
