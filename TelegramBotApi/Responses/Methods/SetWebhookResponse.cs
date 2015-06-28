using TelegramBotApi.Responses.Methods.Interfaces;

namespace TelegramBotApi.Responses.Methods
{
    public class SetWebhookResponse : IMethodResponse
    {
        public bool Ok { get; set; }
        public int? ErrorCode { get; set; }
        public string Description { get; set; }

        public static SetWebhookResponse Parse(dynamic data)
        {
            if (data == null)
            {
                return null;
            }

            return new SetWebhookResponse
            {
                Ok = data.ok,
                ErrorCode = data.error_code,
                Description = data.description
            };
        }
    }
}