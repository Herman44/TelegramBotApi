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

            return new UserProfilePhotosResponse();
        }
    }
}