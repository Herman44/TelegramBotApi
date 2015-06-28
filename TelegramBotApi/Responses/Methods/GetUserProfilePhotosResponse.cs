using TelegramBotApi.Responses.Types;
using TelegramBotApi.Responses.Methods.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramBotApi.Responses.Methods
{
    public class GetUserProfilePhotosResponse : IMethodResponse
    {
        public static GetUserProfilePhotosResponse Parse(dynamic data)
        {
            if (data == null)
            {
                return null;
            }

            return new GetUserProfilePhotosResponse
            {
                Ok = data.ok,
                ErrorCode = data.error_code,
                Description = data.description,
                Result = UserProfilePhotosResponse.Parse(data.result)
            };
        }

        public bool Ok { get; set; }
        public int? ErrorCode { get; set; }
        public string Description { get; set; }
        public UserProfilePhotosResponse Result { get; set; }
    }
}
