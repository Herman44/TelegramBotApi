using TelegramBotApi.Http;
using TelegramBotApi.Requests.Types.Interfaces;

namespace TelegramBotApi.Requests.Types
{
    public class InputFileRequest : ITypeRequest
    {
        public enum InputFileTypes
        {
            String,
            File
        }

        private byte[] _file;
        private string _fileExtension;
        private string _fileId;
        public InputFileTypes InputFileType { get; private set; }

        public string FileId
        {
            get { return _fileId; }
            set
            {
                _fileId = value;
                _fileExtension = null;
                _file = null;

                InputFileType = InputFileTypes.String;
            }
        }

        public string FileExtension
        {
            get { return _fileExtension; }
            set
            {
                _fileId = null;
                _fileExtension = value;

                InputFileType = InputFileTypes.File;
            }
        }

        public byte[] File
        {
            get { return _file; }
            set
            {
                _fileId = null;
                _file = value;

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