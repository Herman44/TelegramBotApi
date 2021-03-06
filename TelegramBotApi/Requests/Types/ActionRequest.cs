﻿using TelegramBotApi.Http;
using TelegramBotApi.Requests.Types.Interfaces;

namespace TelegramBotApi.Requests.Types
{
    public class ActionRequest : ITypeRequest
    {
        public enum Actions
        {
            Typing,
            UploadPhoto,
            RecordVideo,
            UploadVideo,
            RecordAudio,
            UploadAudio,
            UploadDocument,
            FindLocation
        }

        public Actions Action { get; set; }

        public void Parse(HttpData httpData, string key)
        {
            string action = null;

            switch (Action)
            {
                case Actions.Typing:
                    action = "typing";
                    break;

                case Actions.UploadPhoto:
                    action = "upload_photo";
                    break;

                case Actions.RecordVideo:
                    action = "record_video";
                    break;

                case Actions.UploadVideo:
                    action = "upload_video";
                    break;

                case Actions.RecordAudio:
                    action = "record_audio";
                    break;

                case Actions.UploadAudio:
                    action = "upload_audio";
                    break;

                case Actions.UploadDocument:
                    action = "upload_document";
                    break;

                case Actions.FindLocation:
                    action = "find_location";
                    break;
            }

            httpData.Parameters.Add(key, action);
        }
    }
}