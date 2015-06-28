using TelegramBotApi.Http;
using TelegramBotApi.Requests.Methods.Interfaces;

namespace TelegramBotApi.Requests.Methods
{
    public class SetWebhookRequest : IMethodRequest
    {
        public string Url { get; set; }

        public string MethodName
        {
            get { return "setWebhook"; }
        }

        public HttpData Parse()
        {
            return new HttpData
            {
                Parameters = new HttpParameterList
                {
                    {"url", Url}
                }
            };
        }
    }
}