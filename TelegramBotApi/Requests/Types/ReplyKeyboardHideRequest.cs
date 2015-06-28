using System.Web.Helpers;
using Api.Requests.Types.Interfaces;
using TelegramBotApi.Http;

namespace TelegramBotApi.Requests.Types
{
    public class ReplyKeyboardHideRequest : ITypeRequest
    {
        public bool HideKeyboard
        {
            get { return true; }
        }

        public bool Selective { get; set; }

        public void Parse(HttpData httpData, string key)
        {
            httpData.Parameters.Add(key, Json.Encode(new
            {
                hide_keyboard = HideKeyboard,
                selective = Selective
            }));
        }
    }
}