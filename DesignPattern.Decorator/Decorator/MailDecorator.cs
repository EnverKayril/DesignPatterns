using DesignPattern.Decorator.DAL;

namespace DesignPattern.Decorator.Decorator
{
    public class MailDecorator : Decorator
    {
        private readonly INotifier _notifier;
        AppDbContext _context = new AppDbContext();

        public MailDecorator(INotifier notifier) : base(notifier)
        {
            _notifier = notifier;
        }

        public void SendMailNotify(Notifier notifier)
        {
            notifier.NotifierSubject = "Toplantı";
            notifier.NotifierCreator = "Scrum Master";
            notifier.NotifierChannel = "GMail - Outlook";
            notifier.NotifierType = "Private Team";
            _context.Notifiers.Add(notifier);
            _context.SaveChanges();
        }

        public override void CreateNotifier(Notifier notifier)
        {
            base.CreateNotifier(notifier);
            SendMailNotify(notifier);
        }
    }
}
