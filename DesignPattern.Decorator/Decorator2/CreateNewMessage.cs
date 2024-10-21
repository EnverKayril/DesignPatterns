using DesignPattern.Decorator.DAL;

namespace DesignPattern.Decorator.Decorator2
{
    public class CreateNewMessage : ISendMessage
    {
        AppDbContext _context = new AppDbContext();
        public void SendMessage(Message message)
        {
            _context.Messages.Add(message);
            _context.SaveChanges();
        }
    }
}
