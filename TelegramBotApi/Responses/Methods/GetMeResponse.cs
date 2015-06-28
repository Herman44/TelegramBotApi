using TelegramBotApi.Responses.Types;
using TelegramBotApi.Responses.Methods.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramBotApi.Responses.Methods
{
    public class GetMeResponse : IMethodResponse
    {
        public static GetMeResponse Parse(dynamic data)
        {
            if (data == null)
            {
                return null;
            }

            return new GetMeResponse
            {
                Ok = data.ok,
                ErrorCode = data.error_code,
                Description = data.description,
                Result = UserResponse.Parse(data.result)
            };
        }

        public bool Ok { get; set; }
        public int? ErrorCode { get; set; }
        public string Description { get; set; }
        public UserResponse Result { get; set; }
    }
}
