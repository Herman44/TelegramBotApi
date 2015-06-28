using TelegramBotApi.Responses.Types;
using TelegramBotApi.Responses.Methods.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramBotApi.Responses.Methods
{
    public class SendChatActionResponse : IMethodResponse
    {
        public static SendChatActionResponse Parse(dynamic data)
        {
            if (data == null)
            {
                return null;
            }

            return new SendChatActionResponse
            {
                Ok = data.ok,
                ErrorCode = data.error_code,
                Description = data.description
            };
        }

        public bool Ok { get; set; }
        public int? ErrorCode { get; set; }
        public string Description { get; set; }
    }
}
