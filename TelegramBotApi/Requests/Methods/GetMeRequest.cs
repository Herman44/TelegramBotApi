using TelegramBotApi.Http;
using TelegramBotApi.Requests.Methods.Interfaces;

namespace TelegramBotApi.Requests.Methods
{
    public class GetMeRequest : IMethodRequest
    {
        public string MethodName
        {
            get { return "getMe"; }
        }

        public HttpData Parse()
        {
            return new HttpData();
        }
    }
}