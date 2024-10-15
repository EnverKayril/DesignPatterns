using DesignPattern.CQRS.CQRSPattern.Results;
using DesignPattern.CQRS.DAL;
using System.Collections.Generic;
using System.Linq;

namespace DesignPattern.CQRS.CQRSPattern.Handlers
{
    public class GetProductQueryHandler
    {
        private readonly AppDbContext _context;

        public GetProductQueryHandler(AppDbContext context)
        {
            _context = context;
        }

        public IList<GetProductQueryResult> Handle()
        {
            var values = _context.Products.Select(x => new GetProductQueryResult
            {
                ProductId = x.ProductId,
                ProductName = x.Name,
                Stock = x.Stock,
                Price = x.Price
            }).ToList();
            return values;
        }
    }
}