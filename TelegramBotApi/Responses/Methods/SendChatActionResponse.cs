using TelegramBotApi.Responses.Methods.Interfaces;

namespace TelegramBotApi.Responses.Methods
{
    public class SendChatActionResponse : IMethodResponse
    {
        public bool Ok { get; set; }
        public int? ErrorCode { get; set; }
        public string Description { get; set; }

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
    }
}