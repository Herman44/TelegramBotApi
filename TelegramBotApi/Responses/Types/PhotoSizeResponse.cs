using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramBotApi.Responses.Types
{
    public class PhotoSizeResponse
    {
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

        public string FileId { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int? FileSize { get; set; }
    }
}
