namespace TelegramBotApi.Responses.Methods.Interfaces
{
    public interface IMethodResponse
    {
        bool Ok { get; set; }
        int? ErrorCode { get; set; }
        string Description { get; set; }
    }
}