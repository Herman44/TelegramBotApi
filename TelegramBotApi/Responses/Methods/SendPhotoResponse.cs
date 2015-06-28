﻿using TelegramBotApi.Responses.Types;
using TelegramBotApi.Responses.Methods.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramBotApi.Responses.Methods
{
    public class SendPhotoResponse : IMethodResponse
    {
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

        public bool Ok { get; set; }
        public int? ErrorCode { get; set; }
        public string Description { get; set; }
        public MessageResponse Result { get; set; }
    }
}