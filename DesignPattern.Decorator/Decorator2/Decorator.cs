using DesignPattern.Decorator.DAL;

namespace DesignPattern.Decorator.Decorator2
{
    public class Decorator : ISendMessage
    {
        private readonly ISendMessage _sendMessage;

        public Decorator(ISendMessage sendMessage)
        {
            _sendMessage = sendMessage;
        }

        virtual public void SendMessage(Message message)
        {
            message.MessageReceiver = "Everyone";
            message.MessageSender = "Admin";
            message.MessageContent = "This message is sent by Admin to Everyone";
            message.MessageSubject = "Admin Message";
            _sendMessage.SendMessage(message);

        }
    }
}
