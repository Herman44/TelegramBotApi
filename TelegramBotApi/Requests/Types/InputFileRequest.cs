using Api.Requests.Types.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelegramBotApi.Http;

namespace TelegramBotApi.Requests.Types
{
    public class InputFileRequest : ITypeRequest
    {
        public void Parse(HttpData httpData, string key)
        {
            switch (InputFileType)
            {
                case InputFileTypes.String:
                    httpData.Parameters.Add(key, FileId);
                    break;

                case InputFileTypes.File:
                    httpData.Files.Add(key, FileExtension, File);
                    break;
            }
        }

        public enum InputFileTypes
        {
            String,
            File
        }

        private InputFileTypes inputFileType;
        public InputFileTypes InputFileType
        {
            get
            {
                return inputFileType;
            }
        }

        private string fileId;
        public string FileId
        {
            get
            {
                return fileId;
            }
            set
            {
                fileId = value;
                fileExtension = null;
                file = null;

                inputFileType = InputFileTypes.String;
            }
        }

        private string fileExtension;
        public string FileExtension
        {
            get
            {
                return fileExtension;
            }
            set
            {
                fileId = null;
                fileExtension = value;

                inputFileType = InputFileTypes.File;
            }
        }
        private byte[] file;
        public byte[] File
        {
            get
            {
                return file;
            }
            set
            {
                fileId = null;
                file = value;

                inputFileType = InputFileTypes.File;
            }
        }
    }
}
