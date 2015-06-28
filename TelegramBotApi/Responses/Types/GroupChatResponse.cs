namespace TelegramBotApi.Responses.Types
{
    public class GroupChatResponse
    {
        /// <summary>
        ///     Unique identifier for this group chat
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        ///     Group name
        /// </summary>
        public string Title { get; set; }

        public static GroupChatResponse Parse(dynamic data)
        {
            if (data == null)
            {
                return null;
            }

            return new GroupChatResponse
            {
                Id = data.id,
                Title = data.title
            };
        }
    }
}