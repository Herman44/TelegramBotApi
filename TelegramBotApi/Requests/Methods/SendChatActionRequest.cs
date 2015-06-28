using TelegramBotApi.Requests.Types;
using TelegramBotApi.Requests.Methods.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Api.Requests.Types;
using TelegramBotApi.Http;

namespace TelegramBotApi.Requests.Methods
{
    public class SendChatActionRequest : IMethodRequest
    {
        public string MethodName { get { return "sendChatAction"; } }

        public HttpData Parse()
        {
            var httpData = new HttpData
            {
                Parameters = new HttpParameterList {
                    { "chat_id", ChatId }
                }
            };

            if (Action != null)
            {
                Action.Parse(httpData, "action");
            }

            return httpData;
        }

        public int ChatId { get; set; }
        public ActionRequest Action { get; set; }
    }
}