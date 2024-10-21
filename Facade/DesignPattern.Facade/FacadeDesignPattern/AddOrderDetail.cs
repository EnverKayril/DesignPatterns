using DesignPattern.Facade.DAL;

namespace DesignPattern.Facade.FacadeDesignPattern
{
    public class AddOrderDetail
    {
        AppDbContext _context = new AppDbContext();

        public void AddNewOrderDetail(OrderDetail orderDetail)
        {
            _context.OrderDetails.Add(orderDetail);
            _context.SaveChanges();
        }

    }
}
