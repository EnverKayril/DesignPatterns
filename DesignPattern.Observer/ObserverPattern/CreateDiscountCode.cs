using DesignPattern.Observer.DAL;

namespace DesignPattern.Observer.ObserverPattern
{
    public class CreateDiscountCode : IObserver
    {
        private readonly IServiceProvider _serviceProvider;
        AppDbContext _context = new AppDbContext();

        public CreateDiscountCode(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        public void CreateNewUser(AppUser appUser)
        {
            _context.Discounts.Add(new Discount
            {
                DiscountCode = "DISCOUNTCODE",
                DiscountAmount = 35,
                DiscountCodeStatus = true
            });
            _context.SaveChanges();
        }
    }
}
