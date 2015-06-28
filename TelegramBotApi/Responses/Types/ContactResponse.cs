namespace TelegramBotApi.Responses.Types
{
    public class ContactResponse
    {
        public static ContactResponse Parse(dynamic data)
        {
            if (data == null)
            {
                return null;
            }

            return new ContactResponse();
        }
    }
}