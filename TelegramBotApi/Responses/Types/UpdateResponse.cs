namespace TelegramBotApi.Responses.Types
{
    public class UpdateResponse
    {
        public int UpdateId { get; set; }
        public MessageResponse Message { get; set; }

        public static UpdateResponse Parse(dynamic data)
        {
            if (data == null)
            {
                return null;
            }

            return new UpdateResponse
            {
                UpdateId = data.update_id,
                Message = MessageResponse.Parse(data.message)
            };
        }
    }
}