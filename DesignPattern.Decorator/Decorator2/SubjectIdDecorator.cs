using DesignPattern.Decorator.DAL;

namespace DesignPattern.Decorator.Decorator2
{
    public class SubjectIdDecorator : Decorator
    {
        private readonly ISendMessage _sendMessage;
        AppDbContext _context = new AppDbContext();
        public SubjectIdDecorator(ISendMessage sendMessage) : base(sendMessage)
        {
            _sendMessage = sendMessage;
        }

        public void SendMessageIdSubject(Message message)
        {
            if (message.MessageSubject == "1")
            {
                message.MessageSubject = "Toplantı";
            }
            if (message.MessageSubject == "2") 
            { 
                message.MessageSubject = "Duyuru";
            }
            if (message.MessageSubject == "3")
            {
                message.MessageSubject = "Eğitim";
            }
            _context.Messages.Add(message);
            _context.SaveChanges();
        }
        public override void SendMessage(Message message)
        {
            base.SendMessage(message);
            SendMessageIdSubject(message);
        }
    }
}
