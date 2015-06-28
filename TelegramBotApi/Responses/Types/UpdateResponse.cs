using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramBotApi.Responses.Types
{
    public class UpdateResponse
    {
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

        public int UpdateId { get; set; }
        public MessageResponse Message { get; set; }
    }
}
