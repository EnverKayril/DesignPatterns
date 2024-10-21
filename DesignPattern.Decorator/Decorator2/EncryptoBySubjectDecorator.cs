using DesignPattern.Decorator.DAL;

namespace DesignPattern.Decorator.Decorator2
{
    public class EncryptoBySubjectDecorator : Decorator
    {
        private readonly ISendMessage _sendMessage;
        AppDbContext _context = new AppDbContext();

        public EncryptoBySubjectDecorator(ISendMessage sendMessage) : base(sendMessage)
        {
            _sendMessage = sendMessage;
        }

        public void SendMessageByEncryptoSubject(Message message)
        {

            string data = "";
            data = message.MessageSubject;
            char[] charArray = data.ToCharArray();
            foreach (char c in charArray)
            {
                message.MessageSubject += Convert.ToChar(c + 3).ToString();
            }
            _context.Messages.Add(message);
            _context.SaveChanges();
        }
        public override void SendMessage(Message message)
        {
            base.SendMessage(message);
            SendMessageByEncryptoSubject(message);
        }

    }
}
