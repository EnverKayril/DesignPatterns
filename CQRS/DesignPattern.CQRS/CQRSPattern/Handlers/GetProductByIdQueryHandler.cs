using DesignPattern.CQRS.CQRSPattern.Queries;
using DesignPattern.CQRS.CQRSPattern.Results;
using DesignPattern.CQRS.DAL;

namespace DesignPattern.CQRS.CQRSPattern.Handlers
{
    public class GetProductByIdQueryHandler
    {
        private readonly AppDbContext _context;

        public GetProductByIdQueryHandler(AppDbContext context)
        {
            _context = context;
        }

        public GetProductByIdQueryResult Handle(GetProductByIdQuery query)
        {
            var values = _context.Set<Product>().Find(query.Id);
            return new GetProductByIdQueryResult
            {
                Name = values.Name,
                Stock = values.Stock,
                Price = values.Price,
                ProductId = values.ProductId
            };
        }
    }
}
