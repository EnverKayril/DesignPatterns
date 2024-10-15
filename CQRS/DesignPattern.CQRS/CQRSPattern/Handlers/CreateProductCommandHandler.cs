using DesignPattern.CQRS.CQRSPattern.Comments;
using DesignPattern.CQRS.DAL;

namespace DesignPattern.CQRS.CQRSPattern.Handlers
{
    public class CreateProductCommandHandler
    {
        private readonly AppDbContext _context;

        public CreateProductCommandHandler(AppDbContext context)
        {
            _context = context;
        }

        public void Handle(CreateProductCommand command)
        {
            var product = new Product
            {
                Name = command.Name,
                Stock = command.Stock,
                Price = command.Price,
                Description = command.Description,
                Status = true
            };
            _context.Products.Add(product);
            _context.SaveChanges();
        }
    }
}
