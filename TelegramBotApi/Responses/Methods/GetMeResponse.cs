using TelegramBotApi.Responses.Methods.Interfaces;
using TelegramBotApi.Responses.Types;

namespace TelegramBotApi.Responses.Methods
{
    public class GetMeResponse : IMethodResponse
    {
        public UserResponse Result { get; set; }
        public bool Ok { get; set; }
        public int? ErrorCode { get; set; }
        public string Description { get; set; }

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
    }
}