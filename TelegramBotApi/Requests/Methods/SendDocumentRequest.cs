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
    public class SendDocumentRequest : IMethodRequest
    {
        public string MethodName { get { return "sendDocument"; } }

        public HttpData Parse()
        {
            var httpData = new HttpData
            {
                Parameters = new HttpParameterList {
                    { "chat_id", ChatId },
                    { "reply_to_message_id", ReplyToMessageId }
                }
            };

            if (Document != null)
            {
                Document.Parse(httpData, "document");
            }
            if (ReplyMarkup != null)
            {
                ReplyMarkup.Parse(httpData, "reply_markup");
            }

            return httpData;
        }

        public int ChatId { get; set; }
        public InputFileRequest Document { get; set; }
        public int ReplyToMessageId { get; set; }
        public ReplyMarkupRequest ReplyMarkup { get; set; }
    }
}
