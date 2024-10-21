using DesignPattern.Facade.DAL;

namespace DesignPattern.Facade.FacadeDesignPattern
{
    public class ProductStock
    {
        AppDbContext _context = new AppDbContext();

        public void StockDecrease(int id, int amount)
        {
            var value = _context.Products.Find(id);
            value.ProductStock -= amount;
            _context.SaveChanges();
        }
    }
}
