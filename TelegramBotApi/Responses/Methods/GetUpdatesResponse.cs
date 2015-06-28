using System.Collections.Generic;
using TelegramBotApi.Responses.Methods.Interfaces;
using TelegramBotApi.Responses.Types;

namespace TelegramBotApi.Responses.Methods
{
    public class GetUpdatesResponse : IMethodResponse
    {
        public List<UpdateResponse> Result { get; set; }
        public bool Ok { get; set; }
        public int? ErrorCode { get; set; }
        public string Description { get; set; }

        public static GetUpdatesResponse Parse(dynamic data)
        {
            if (data == null)
            {
                return null;
            }

            var getUpdatesResponse = new GetUpdatesResponse
            {
                Ok = data.ok,
                ErrorCode = data.error_code,
                Description = data.description,
                Result = new List<UpdateResponse>()
            };

            foreach (var result in data.result)
            {
                getUpdatesResponse.Result.Add(UpdateResponse.Parse(result));
            }

            return getUpdatesResponse;
        }
    }
}