using TelegramBotApi.Http;
using TelegramBotApi.Requests.Methods.Interfaces;
using TelegramBotApi.Requests.Types;

namespace TelegramBotApi.Requests.Methods
{
    public class SendMessageRequest : IMethodRequest
    {
        public int ChatId { get; set; }
        public string Text { get; set; }
        public bool DisableWebPagePreview { get; set; }
        public int? ReplyToMessageId { get; set; }
        public ReplyMarkupRequest ReplyMarkup { get; set; }

        public string MethodName
        {
            get { return "sendMessage"; }
        }

        public HttpData Parse()
        {
            var httpData = new HttpData
            {
                Parameters = new HttpParameterList
                {
                    {"chat_id", ChatId},
                    {"text", Text},
                    {"disable_web_page_preview", DisableWebPagePreview},
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