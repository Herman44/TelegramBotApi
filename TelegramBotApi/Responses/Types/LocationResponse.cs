namespace TelegramBotApi.Responses.Types
{
    public class LocationResponse
    {
        public static LocationResponse Parse(dynamic data)
        {
            if (data == null)
            {
                return null;
            }

            return new LocationResponse();
        }
    }
}