using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramBotApi.Responses.Types
{
    public class UserProfilePhotosResponse 
    {
        public static UserProfilePhotosResponse Parse(dynamic data)
        {
            if (data == null)
            {
                return null;
            }

            return new UserProfilePhotosResponse
            {
            };
        }
    }
}
