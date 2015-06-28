namespace TelegramBotApi.Responses.Types
{
    public class VideoResponse
    {
        public static VideoResponse Parse(dynamic data)
        {
            if (data == null)
            {
                return null;
            }

            return new VideoResponse();
        }
    }
}