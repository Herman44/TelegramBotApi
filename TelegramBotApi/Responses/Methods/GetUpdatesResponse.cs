using TelegramBotApi.Responses.Types;
using TelegramBotApi.Responses.Methods.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramBotApi.Responses.Methods
{
    public class GetUpdatesResponse : IMethodResponse
    {
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

        public bool Ok { get; set; }
        public int? ErrorCode { get; set; }
        public string Description { get; set; }
        public List<UpdateResponse> Result { get; set; }
    }
}
