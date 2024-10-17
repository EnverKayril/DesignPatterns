using MediatR;

namespace DesignPattern.Mediator.MediatorPattern.Commands
{
    public class RemoveProductCommand : IRequest
    {
        public RemoveProductCommand(int productId)
        {
            ProductId = productId;
        }

        public int ProductId { get; set; }
    }
}
