using DesignPattern.Decorator.DAL;

namespace DesignPattern.Decorator.Decorator
{
    public class CreateNotifier : INotifier
    {
        AppDbContext _context = new AppDbContext();
        void INotifier.CreateNotifier(Notifier notifier)
        {
            _context.Notifiers.Add(notifier);
            _context.SaveChanges();
        }
    }
}
