using TelegramBotApi.Http;
using TelegramBotApi.Requests.Methods.Interfaces;
using TelegramBotApi.Requests.Types;

namespace TelegramBotApi.Requests.Methods
{
    public class SendStickerRequest : IMethodRequest
    {
        public int ChatId { get; set; }
        public InputFileRequest Sticker { get; set; }
        public int ReplyToMessageId { get; set; }
        public ReplyMarkupRequest ReplyMarkup { get; set; }

        public string MethodName
        {
            get { return "sendSticker"; }
        }

        public HttpData Parse()
        {
            var httpData = new HttpData
            {
                Parameters = new HttpParameterList
                {
                    {"chat_id", ChatId},
                    {"reply_to_message_id", ReplyToMessageId}
                }
            };

            if (Sticker != null)
            {
                Sticker.Parse(httpData, "sticker");
            }
            if (ReplyMarkup != null)
            {
                ReplyMarkup.Parse(httpData, "reply_markup");
            }

            return httpData;
        }
    }
}