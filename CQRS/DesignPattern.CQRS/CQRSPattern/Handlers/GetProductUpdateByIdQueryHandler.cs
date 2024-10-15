using DesignPattern.CQRS.CQRSPattern.Queries;
using DesignPattern.CQRS.CQRSPattern.Results;
using DesignPattern.CQRS.DAL;

namespace DesignPattern.CQRS.CQRSPattern.Handlers
{
    public class GetProductUpdateByIdQueryHandler
    {
        private readonly AppDbContext _context;

        public GetProductUpdateByIdQueryHandler(AppDbContext context)
        {
            _context = context;
        }

        public GetProductUpdateQueryResult Handle(GetProductUpdateByIdQuery query)
        {
            var value = _context.Products.Find(query.Id);
            return new GetProductUpdateQueryResult
            {
                Description = value.Description,
                Name = value.Name,
                Price = value.Price,
                Stock = value.Stock,
                ProductId = value.ProductId,
            };
        }
    }
}
