using TelegramBotApi.Requests.Methods.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelegramBotApi.Http;

namespace TelegramBotApi.Requests.Methods
{
    public class ForwardMessageRequest : IMethodRequest
    {
        public string MethodName { get { return "forwardMessage"; } }

        public HttpData Parse()
        {
            return new HttpData
            {
                Parameters = new HttpParameterList {
                    { "chat_id", ChatId },
                    { "from_chat_id", FromChatId },
                    { "message_id", MessageId }
                }
            };
        }

        public int ChatId { get; set; }
        public int FromChatId { get; set; }
        public int MessageId { get; set; }
    }
}
