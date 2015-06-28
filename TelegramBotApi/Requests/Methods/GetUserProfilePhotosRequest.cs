using TelegramBotApi.Http;
using TelegramBotApi.Requests.Methods.Interfaces;

namespace TelegramBotApi.Requests.Methods
{
    public class GetUserProfilePhotosRequest : IMethodRequest
    {
        public int UserId { get; set; }
        public int Offset { get; set; }
        public int Limit { get; set; }

        public string MethodName
        {
            get { return "getUserProfilePhotos"; }
        }

        public HttpData Parse()
        {
            return new HttpData
            {
                Parameters = new HttpParameterList
                {
                    {"user_id", UserId},
                    {"offset", Offset},
                    {"limit", Limit}
                }
            };
        }
    }
}