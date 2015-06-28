using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramBotApi.Responses.Types
{
    public class DocumentResponse 
    {
        public static DocumentResponse Parse(dynamic data)
        {
            if (data == null)
            {
                return null;
            }

            return new DocumentResponse
            {
                FileId = data.file_id,
                Thumb = PhotoSizeResponse.Parse(data.thumb),
                FileName = data.file_name,
                MimeType = data.mime_type,
                FileSize = data.file_size
            };
        }

        public string FileId { get; set; }
        public PhotoSizeResponse Thumb { get; set; }
        public string FileName { get; set; }
        public string MimeType { get; set; }
        public int FileSize { get; set; }
    }
}
