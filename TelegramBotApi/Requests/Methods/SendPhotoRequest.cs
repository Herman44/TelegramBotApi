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
    public class SendPhotoRequest : IMethodRequest
    {
        public string MethodName { get { return "sendPhoto"; } }

        public HttpData Parse()
        {
            var httpData = new HttpData
            {
                Parameters = new HttpParameterList { 
                    { "chat_id", ChatId },
                    { "caption",  Caption },
                    { "reply_to_message_id", ReplyToMessageId }
                }
            };

            if (Photo != null)
            {
                Photo.Parse(httpData, "photo");
            }
            if (ReplyMarkup != null)
            {
                ReplyMarkup.Parse(httpData, "reply_markup");
            }

            return httpData;
        }

        public int ChatId { get; set; }
        public InputFileRequest Photo { get; set; }
        public string Caption { get; set; }
        public int ReplyToMessageId { get; set; }
        public ReplyMarkupRequest ReplyMarkup { get; set; }
    }
}
