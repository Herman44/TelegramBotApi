using TelegramBotApi.Http;
using TelegramBotApi.Requests.Methods.Interfaces;
using TelegramBotApi.Requests.Types;

namespace TelegramBotApi.Requests.Methods
{
    public class SendAudioRequest : IMethodRequest
    {
        public int ChatId { get; set; }
        public InputFileRequest Audio { get; set; }
        public int ReplyToMessageId { get; set; }
        public ReplyMarkupRequest ReplyMarkup { get; set; }

        public string MethodName
        {
            get { return "sendAudio"; }
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

            if (Audio != null)
            {
                Audio.Parse(httpData, "audio");
            }
            if (ReplyMarkup != null)
            {
                ReplyMarkup.Parse(httpData, "reply_markup");
            }

            return httpData;
        }
    }
}