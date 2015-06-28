using TelegramBotApi.Requests.Types;
using TelegramBotApi.Requests.Methods.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelegramBotApi.Http;

namespace TelegramBotApi.Requests.Methods
{
    public class SendLocationRequest : IMethodRequest
    {
        public string MethodName { get { return "sendLocation"; } }

        public HttpData Parse()
        {
            var httpData = new HttpData {
                Parameters = new HttpParameterList {
                    { "chat_id", ChatId },
                    { "latitude", Latitude },
                    { "longitude", Longitude },
                    { "reply_to_message_id", ReplyToMessageId }
                }
            };

            if (ReplyMarkup != null)
            {
                ReplyMarkup.Parse(httpData, "reply_markup");
            }

            return httpData;
        }

        public int ChatId { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public int ReplyToMessageId { get; set; }
        public ReplyMarkupRequest ReplyMarkup { get; set; }
    }
}
