using TelegramBotApi.Http;
using TelegramBotApi.Requests.Methods.Interfaces;

namespace TelegramBotApi.Requests.Methods
{
    public class ForwardMessageRequest : IMethodRequest
    {
        public int ChatId { get; set; }
        public int FromChatId { get; set; }
        public int MessageId { get; set; }

        public string MethodName
        {
            get { return "forwardMessage"; }
        }

        public HttpData Parse()
        {
            return new HttpData
            {
                Parameters = new HttpParameterList
                {
                    {"chat_id", ChatId},
                    {"from_chat_id", FromChatId},
                    {"message_id", MessageId}
                }
            };
        }
    }
}