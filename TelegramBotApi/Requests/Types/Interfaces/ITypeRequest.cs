using TelegramBotApi.Http;

namespace TelegramBotApi.Requests.Types.Interfaces
{
    public interface ITypeRequest
    {
        void Parse(HttpData httpData, string key);
    }
}