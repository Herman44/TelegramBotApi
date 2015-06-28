namespace TelegramBotApi.Responses.Types
{
    public class PhotoSizeResponse
    {
        public string FileId { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int? FileSize { get; set; }

        public static PhotoSizeResponse Parse(dynamic data)
        {
            if (data == null)
            {
                return null;
            }

            return new PhotoSizeResponse
            {
                FileId = data.file_id,
                Width = data.width,
                Height = data.height,
                FileSize = data.file_size
            };
        }
    }
}