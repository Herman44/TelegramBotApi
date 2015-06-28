using Api.Requests.Types.Interfaces;
using TelegramBotApi.Http;

namespace TelegramBotApi.Requests.Types
{
    public class InputFileRequest : ITypeRequest
    {
        public enum InputFileTypes
        {
            String,
            File
        }

        private byte[] file;
        private string fileExtension;
        private string fileId;
        public InputFileTypes InputFileType { get; private set; }

        public string FileId
        {
            get { return fileId; }
            set
            {
                fileId = value;
                fileExtension = null;
                file = null;

                InputFileType = InputFileTypes.String;
            }
        }

        public string FileExtension
        {
            get { return fileExtension; }
            set
            {
                fileId = null;
                fileExtension = value;

                InputFileType = InputFileTypes.File;
            }
        }

        public byte[] File
        {
            get { return file; }
            set
            {
                fileId = null;
                file = value;

                InputFileType = InputFileTypes.File;
            }
        }

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
    }
}