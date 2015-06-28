using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelegramBotApi;
using TelegramBotApi.Http;
using TelegramBotApi.Requests.Methods.Interfaces;

namespace TelegramBotApi.Requests.Methods
{
    public class GetUpdatesRequest : IMethodRequest
    {
        public string MethodName { get { return "getUpdates"; } }

        public HttpData Parse()
        {
            return new HttpData
            {
                Parameters = new HttpParameterList {
                    { "offset", Offset },
                    { "limit", Limit },
                    { "timeout", Timeout }
                }
            };
        }

        public int? Offset { get; set; }
        public int? Limit { get; set; }
        public int? Timeout { get; set; }
    }
}
