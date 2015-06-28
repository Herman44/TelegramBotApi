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
    public class ReplyKeyboardHideRequest : ITypeRequest
    {
        public void Parse(HttpData httpData, string key)
        {
            httpData.Parameters.Add(key, Json.Encode(new
            {
                hide_keyboard = HideKeyboard,
                selective = Selective
            }));
        }

        public bool HideKeyboard { get { return true; } }
        public bool Selective { get; set; }
    }
}
