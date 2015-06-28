using TelegramBotApi.Http;

namespace TelegramBotApi.Requests.Methods.Interfaces
{
    public interface IMethodRequest
    {
        string MethodName { get; }
        HttpData Parse();
    }
}