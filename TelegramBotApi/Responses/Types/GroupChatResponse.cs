using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramBotApi.Responses.Types
{
    public class GroupChatResponse
    {
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

        /// <summary>
        /// Unique identifier for this group chat
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Group name
        /// </summary>
        public string Title { get; set; }
    }
}
