using DesignPattern.Decorator.DAL;

namespace DesignPattern.Decorator.Decorator2
{
    public class EncryptByContentDecorator : Decorator
    {
        private readonly ISendMessage _sendMessage;
        AppDbContext _context = new AppDbContext();

        public EncryptByContentDecorator(ISendMessage sendMessage) : base(sendMessage)
        {
            _sendMessage = sendMessage;
        }

        public void SendMessageByEncryptoContent(Message message)
        {
            message.MessageSender = "Takım Lideri";
            message.MessageReceiver = "Yazılım Ekibi";
            message.MessageContent = "Bu mesaj Takım Lideri tarafından Yazılım Ekibine gönderilmiştir.";
            message.MessageSubject = "Toplantı";
            string data = "";
            data = message.MessageContent;
            char[] charArray = data.ToCharArray();
            foreach (char c in charArray)
            {
                message.MessageContent += Convert.ToChar(c + 3).ToString();
            }
            _context.Messages.Add(message);
            _context.SaveChanges();
        }
        public override void SendMessage(Message message)
        {
            base.SendMessage(message);
            SendMessageByEncryptoContent(message);
        }
    }
}
