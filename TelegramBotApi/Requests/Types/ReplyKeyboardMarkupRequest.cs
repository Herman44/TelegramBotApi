using Api.Requests.Types.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Helpers;
using TelegramBotApi.Http;

namespace TelegramBotApi.Requests.Types
{
    public class ReplyKeyboardMarkupRequest : ITypeRequest
    {
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

        public List<List<string>> Keyboard { get; set; }
        public bool ResizeKeyboard { get; set; }
        public bool OneTimeKeyboard { get; set; }
        public bool Selective { get; set; }
    }
}
