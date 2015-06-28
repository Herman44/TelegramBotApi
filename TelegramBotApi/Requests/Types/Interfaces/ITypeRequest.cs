using TelegramBotApi.Http;

namespace Api.Requests.Types.Interfaces
{
    public interface ITypeRequest
    {
        void Parse(HttpData httpData, string key);
    }
}