using System.Collections.Generic;
using System.Web.Helpers;
using TelegramBotApi.Http;
using TelegramBotApi.Requests.Types.Interfaces;

namespace TelegramBotApi.Requests.Types
{
    public class ReplyKeyboardMarkupRequest : ITypeRequest
    {
        public List<List<string>> Keyboard { get; set; }
        public bool ResizeKeyboard { get; set; }
        public bool OneTimeKeyboard { get; set; }
        public bool Selective { get; set; }

        public void Parse(HttpData httpData, string key)
        {
            httpData.Parameters.Add(key, Json.Encode(new
            {
                keyboard = Keyboard,
                resize_keyboard = ResizeKeyboard,
                one_time_keyboard = OneTimeKeyboard,
                selective = Selective
            }));
        }
    }
}