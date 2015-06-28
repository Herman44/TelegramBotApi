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
    public class GetUserProfilePhotosRequest : IMethodRequest
    {
        public string MethodName { get { return "getUserProfilePhotos"; } }

        public HttpData Parse()
        {
            return new HttpData
            {
                Parameters = new HttpParameterList {
                    { "user_id", UserId },
                    { "offset", Offset },
                    { "limit", Limit }
                }
            };
        }

        public int UserId { get; set; }
        public int Offset { get; set; }
        public int Limit { get; set; }
    }
}
