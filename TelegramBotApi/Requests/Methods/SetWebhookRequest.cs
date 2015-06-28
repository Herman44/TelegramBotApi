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
    public class SetWebhookRequest : IMethodRequest
    {
        public string MethodName { get { return "setWebhook"; } }

        public HttpData Parse()
        {
            return new HttpData {
                Parameters = new HttpParameterList {
                    { "url", Url }
                }
            };
        }

        public string Url { get; set; }
    }
}
