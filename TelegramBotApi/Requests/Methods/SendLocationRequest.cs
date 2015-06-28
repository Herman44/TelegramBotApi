using TelegramBotApi.Http;
using TelegramBotApi.Requests.Methods.Interfaces;
using TelegramBotApi.Requests.Types;

namespace TelegramBotApi.Requests.Methods
{
    public class SendLocationRequest : IMethodRequest
    {
        public int ChatId { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public int ReplyToMessageId { get; set; }
        public ReplyMarkupRequest ReplyMarkup { get; set; }

        public string MethodName
        {
            get { return "sendLocation"; }
        }

        public HttpData Parse()
        {
            var httpData = new HttpData
            {
                Parameters = new HttpParameterList
                {
                    {"chat_id", ChatId},
                    {"latitude", Latitude},
                    {"longitude", Longitude},
                    {"reply_to_message_id", ReplyToMessageId}
                }
            };

            if (ReplyMarkup != null)
            {
                ReplyMarkup.Parse(httpData, "reply_markup");
            }

            return httpData;
        }
    }
}