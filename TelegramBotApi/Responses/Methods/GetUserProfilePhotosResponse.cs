﻿using TelegramBotApi.Responses.Methods.Interfaces;
using TelegramBotApi.Responses.Types;

namespace TelegramBotApi.Responses.Methods
{
    public class GetUserProfilePhotosResponse : IMethodResponse
    {
        public UserProfilePhotosResponse Result { get; set; }
        public bool Ok { get; set; }
        public int? ErrorCode { get; set; }
        public string Description { get; set; }

        public static GetUserProfilePhotosResponse Parse(dynamic data)
        {
            if (data == null)
            {
                return null;
            }

            return new GetUserProfilePhotosResponse
            {
                Ok = data.ok,
                ErrorCode = data.error_code,
                Description = data.description,
                Result = UserProfilePhotosResponse.Parse(data.result)
            };
        }
    }
}