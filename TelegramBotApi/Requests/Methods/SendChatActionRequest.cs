using TelegramBotApi.Http;
using TelegramBotApi.Requests.Methods.Interfaces;
using TelegramBotApi.Requests.Types;

namespace TelegramBotApi.Requests.Methods
{
    public class SendChatActionRequest : IMethodRequest
    {
        public int ChatId { get; set; }
        public ActionRequest Action { get; set; }

        public string MethodName
        {
            get { return "sendChatAction"; }
        }

        public HttpData Parse()
        {
            var httpData = new HttpData
            {
                Parameters = new HttpParameterList
                {
                    {"chat_id", ChatId}
                }
            };

            if (Action != null)
            {
                Action.Parse(httpData, "action");
            }

            return httpData;
        }
    }
}