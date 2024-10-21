using DesignPattern.Facade.DAL;

namespace DesignPattern.Facade.FacadeDesignPattern
{
    public class AddOrder
    {
        AppDbContext _context = new AppDbContext();

        public void AddNewOrder(Order order)
        {
            order.OrderDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            _context.Orders.Add(order);
            _context.SaveChanges();
        }
    }
}
