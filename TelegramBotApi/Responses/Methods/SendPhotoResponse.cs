﻿using TelegramBotApi.Responses.Methods.Interfaces;
using TelegramBotApi.Responses.Types;

namespace TelegramBotApi.Responses.Methods
{
    public class SendPhotoResponse : IMethodResponse
    {
        public MessageResponse Result { get; set; }
        public bool Ok { get; set; }
        public int? ErrorCode { get; set; }
        public string Description { get; set; }

        public static SendPhotoResponse Parse(dynamic data)
        {
            if (data == null)
            {
                return null;
            }

            return new SendPhotoResponse
            {
                Ok = data.ok,
                ErrorCode = data.error_code,
                Description = data.description,
                Result = MessageResponse.Parse(data.result)
            };
        }
    }
}